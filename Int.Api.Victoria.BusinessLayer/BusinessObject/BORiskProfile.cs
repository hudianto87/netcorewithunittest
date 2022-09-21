using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BORiskProfile : IBORiskProfile
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BORiskProfile(DBContext db)
        {
            dbContext = db;
            boReference = new (dbContext);
            responseCode = new();
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRRiskProfile>> ProcessRiskProfile(BMRiskProfile request)
        {
            var result = new ResultBase<BMRRiskProfile>()
            {
                Data = new()
            };

            string[] groupName = new[] { "Sex", "IDType", "Negara", "Agama", "MaritalStatus", "Education", "Objective", "Pendapatan/Bulan(I)",
                    "IDSourceOfMainIncome", "Job" };

            bool isNotMapped = false, isDuplicateNoRekening = false, 
                 isBankCodeNotExist = false, isCurrencyNotExist = false,
                 isDuplicateQuestionNo = false;

            string notMappMsg = "Some fields is not mapped :", duplicateNoRekMsg = "Some NoRekening is duplicate :"
                                ,BankCodeNotExistMsg = "Bank Code Not Exist in WMS :", CurrencyCodeNotExist = "Some currency code not exist in WMS :"
                                ,duplicateQuestionNoMsg = "Some QuestionNo is duplicate :";

            int tempQuestionID = 0,
                tempQuestionOptionID = 0;

            string? GetKotaKTP = string.Empty,
                   GetProvinceKTP = string.Empty,
                   GetKotaTinggal = string.Empty,
                   GetProvinceTinggal = string.Empty,
                   GetHubunganAhliWaris = string.Empty;
            try
            {
                #region Validation

                #region Check Channel
                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(request.ChannelID)).FirstOrDefault();
                }

                if (getDataChannel == null || DataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }
                #endregion

                #region Check Data Sales
                Tagent? dataAgent = await boReference.GetDataAgent(request.ChannelID.Trim());
                if (dataAgent is null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS054);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS054.ToString();
                    return result;
                }

                var existAgentStructureTreeCode2 = await dbContext.TagentStructures.Where(x => x.AgentId == dataAgent.AgentId && !x.IsResign && x.AgentLevelId == 4).Select(x => new { x.IsResign, x.TreeCode2 }).FirstOrDefaultAsync();
                if (existAgentStructureTreeCode2 == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS055);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS055.ToString();
                    return result;
                }
                if (existAgentStructureTreeCode2.IsResign)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS056);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS056.ToString();
                    return result;
                }
                #endregion

                #region Check Exist Bank Code, Check Duplicate Request NoRekeing, Check Exist Currency
                var checkReqNoRekening = request.bankAccounts.Select(x => x.NoRekening.Trim()).AsParallel().Distinct().ToList();
                foreach (var i in checkReqNoRekening)
                {
                    if (request.bankAccounts.Where(x => x.NoRekening.Trim() == i.Trim()).Count() > 1)
                    {
                        isDuplicateNoRekening = true;
                        duplicateNoRekMsg += $" \n - NoRekening {i.Trim()}";
                    }
                }

                if (isDuplicateNoRekening)
                {
                    result.IsOk = false;
                    result.Message = duplicateNoRekMsg;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS107.ToString();
                    return result;
                }

                var BankCode = request.bankAccounts.Select(x => x.BankCode.Trim()).AsParallel().Distinct().ToList();
                var BankCodeExist = await dbContext.TrefBankBranches.Where(x => BankCode.Contains(x.BranchCode)).Select(x => x.BranchCode).ToListAsync();
                foreach (var CheckBankCode in BankCode)
                {
                    if (!BankCodeExist.Where(x => x.Equals(CheckBankCode.Trim())).Any())
                    {
                        isBankCodeNotExist = true;
                        BankCodeNotExistMsg += $"{CheckBankCode.Trim()},";
                    }
                }

                if (isBankCodeNotExist)
                {
                    result.IsOk = false;
                    result.Message = BankCodeNotExistMsg;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS032.ToString();
                    return result;
                }

                var currCode = request.bankAccounts.Select(x => x.MataUang).AsParallel().Distinct().ToList();
                List<TrefCurrency> currCodeExist = await dbContext.TrefCurrencies.Where(x => currCode.Contains(x.CurrencyCode)).AsNoTracking().ToListAsync();

                foreach (var checkCurrCode in currCode)
                {
                    if (!currCodeExist.Where(x => x.CurrencyCode.Equals(checkCurrCode.Trim())).Any())
                    {
                        isCurrencyNotExist = true;
                        CurrencyCodeNotExist += $"{checkCurrCode.Trim()},";
                    }
                }

                if (isCurrencyNotExist)
                {
                    result.IsOk = false;
                    result.Message = CurrencyCodeNotExist;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS083.ToString();
                    return result;
                }
                #endregion

                #region Check Questionare Risk Profile
                var checkReqQuestionNo = request.ListQuestionnaire.Select(x => x.QuestionNo).AsParallel().Distinct().ToList();
                foreach (var resultQuestion in checkReqQuestionNo)
                {
                    if (request.ListQuestionnaire.Where(x => x.QuestionNo == resultQuestion).Count() > 1)
                    {
                        isDuplicateQuestionNo = true;
                        duplicateQuestionNoMsg += $"{resultQuestion},";
                    }
                }

                if (isDuplicateQuestionNo)
                {
                    result.IsOk = false;
                    result.Message = duplicateQuestionNoMsg;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS108.ToString();
                    return result;
                }

                foreach (var item in request.ListQuestionnaire)
                {
                    if (item.Type.Equals("RISK"))
                    {
                        tempQuestionID = await boReference.CheckQuestionRiskProfile(item.QuestionNo);
                        if (tempQuestionID == 0)
                        {
                            result.IsOk = false;
                            result.Message = "Question" + " " + item.QuestionNo + " " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS100);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS100.ToString();
                            return result;
                        }
                        tempQuestionOptionID = await boReference.CheckAnswerRiskProfile(tempQuestionID, item.Answer);
                        if (tempQuestionOptionID == 0)
                        {
                            result.IsOk = false;
                            result.Message = "Answer" + " " + item.QuestionNo + " " + responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS100);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS100.ToString();
                            return result;
                        }
                    }
                }
                #endregion

                #region Check Data Correspond TrefKotaNew And vTreferenceDetail
                var tRefDetail = boReference.TRefferenceDetailValueByManyGroupName(groupName).Result.
                    Select(x => new Tuple<string, string, string>(x.MainValue, x.GroupName, x.AltValue5)).ToList();

                GetProvinceKTP = await boReference.GetKodeKota(request.ProvinsiKTP.Substring(0, 2).Trim());

                GetKotaKTP = await boReference.GetKodeKota(request.KotaKTP.Trim());

                GetProvinceTinggal = await boReference.GetKodeKota(request.ProvinsiTinggal.Substring(0, 2).Trim());

                GetKotaTinggal = await boReference.GetKodeKota(request.KotaTinggal.Trim());

                GetHubunganAhliWaris = await boReference.GetDataByDisplay(request.HubunganAhliwaris.Trim(), "RelationFamily");

                if (string.IsNullOrEmpty(GetProvinceKTP))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Provinsi";
                }

                if (string.IsNullOrEmpty(GetKotaKTP))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Kota";
                }

                if (string.IsNullOrEmpty(GetProvinceTinggal))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Provinsi Tinggal";
                }

                if (string.IsNullOrEmpty(GetKotaTinggal))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Kota Tinggal";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.JenisKelamin.Trim()) && x.Item2 == "Sex"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Jenis Kelamin";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.JenisIdentitas.Trim()) && x.Item2 == "IDType"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Jenis Identitas";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.Kewarganegaraan.Trim()) && x.Item2 == "Negara"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Kewarganegaraan";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.Agama.Trim()) && x.Item2 == "Agama"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Agama";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.StatusPerkawinan.Trim()) && x.Item2 == "MaritalStatus"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Status Pernikahan";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.Pendidikan.Trim()) && x.Item2 == "Education"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Pendidikan";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.MaksudTujuan.Trim()) && x.Item2 == "Objective"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Tujuan Investasi";
                }

                if (!tRefDetail.Any(x => x.Item1.ToLower().Equals(request.Penghasilan.Trim()) && x.Item2 == "Pendapatan/Bulan(I)"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Penghasilan";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.SumberDana.Trim()) && x.Item2 == "IDSourceOfMainIncome"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Sumber Dana";
                }

                if (!tRefDetail.Any(x => x.Item1.Equals(request.Pekerjaan.Trim()) && x.Item2 == "Job"))
                {
                    isNotMapped = true;
                    notMappMsg += " \n - Pekerjaan";
                }

                if (isNotMapped)
                {
                    result.IsOk = false;
                    result.Message = notMappMsg;
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS035.ToString();
                    return result;
                }
                #endregion

                #endregion

                #region Process Save Data KYC When Action Type C and Update Data Risk Profile When Action Type U
                Tcustomer? dataCustomer = new();
                if (request.ActionType.Equals("C"))
                {
                    dataCustomer = await boReference.GetDataCustomer(request.CIF.Trim(), request.NomorIdentitas, request.ChannelID);
                    if (dataCustomer != null)
                    {
                        if (dataCustomer.Idnumber.Equals(request.NomorIdentitas))
                        {
                            result.IsOk = false;
                            result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS031);
                            result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS031.ToString();
                            return result;
                        }

                        result.IsOk = false;
                        result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS030);
                        result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS030.ToString();
                        return result;
                    }

                    var TCus = new Tcustomer()
                    {
                        UnitHolderIdno = request.CIF.Trim(),
                        InvestorType = "I",
                        FirstName = request.NamaDepan.Trim(),
                        MiddleName = request.NamaTengah.Trim(),
                        LastName = request.NamaBelakang.Trim(),
                        FullName = (request.NamaDepan.Trim() ?? "") + " " + (request.NamaTengah.Trim() ?? "") + " " + (request.NamaBelakang.Trim() ?? ""),
                        BirthDate = request.TanggalLahir,
                        BirthPlace = request.TempatLahir.Trim(),
                        Idsex = request.JenisKelamin.Trim(),
                        Idreligi = request.Agama.Trim(),
                        Ideducation = request.Pendidikan.Trim(),
                        Idnationality = request.Kewarganegaraan.Trim() ?? "ID",
                        IdmaritalStatus = request.StatusPerkawinan.Trim(),
                        Npwp = request.NPWP.Trim(),
                        Idtype = request.JenisIdentitas.Trim(),
                        Idnumber = request.NomorIdentitas.Trim(),
                        Idexpired = request.MasaBerlakuID,
                        Email = request.Email.Trim(),
                        MobilePhone = request.NoHP.Trim(),
                        Idincome = request.Penghasilan.Trim(),
                        Idobjectives = request.MaksudTujuan.Trim(),
                        IdsourceOfMainIncome = request.SumberDana.Trim(),
                        Idoccupation = request.Pekerjaan.Trim(),
                        MinUnitHold = 0,
                        IddividendInvest = "RE",
                        DocId = true,
                        DocNotary = true,
                        DocNpwp = true,
                        DocAkta = true,
                        OpDate = DateTime.Now,
                        SpouseName = request.NamaPasangan.Trim(),
                        Heir = request.NamaAhliwaris.Trim(),
                        HeirRelation = GetHubunganAhliWaris,
                        SysActionType = "I",
                        SysRecStatus = true,
                        SysApprovalStatus = 1,
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                        SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        Remark = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        Idstatus = "ACTIVE",
                        MotherName = request.NamaIbuKandung.Trim(),
                        CreatedBy = request.ChannelID.Trim(),
                        CreatedDate = DateTime.Now,
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim()
                    };

                    if (string.IsNullOrEmpty(request.SIDRequested) || request.SIDRequested.Equals("MF"))
                    {
                        TCus.IsMf = true;
                        TCus.OpDateMf = DateTime.Now;
                        TCus.OtherInfo123 = "@@" + request.ChannelID.Trim() + "@@";
                    }

                    if (request.SIDRequested.Equals("SG"))
                    {
                        TCus.IsGovBond = true;
                        TCus.OpDateGovBond = DateTime.Now;
                        TCus.OtherInfo121 = "@@" + request.ChannelID.Trim() + "@@";
                    }

                    if (request.SIDRequested.Equals("SC"))
                    {
                        TCus.IsCorpBond = true;
                        TCus.OpDateCorpBond = DateTime.Now;
                        TCus.OtherInfo122 = "@@" + request.ChannelID.Trim() + "@@";
                    }

                    TCus.TcustomerAddresses.Add(new TcustomerAddress
                    {
                        Address1 = request.AlamatKTP.Trim(),
                        AddressTypeCode = "2",
                        FullName = (request.NamaDepan.Trim() ?? "") + " " + (request.NamaTengah.Trim() ?? "") + " " + (request.NamaBelakang.Trim() ?? ""),
                        City = GetKotaKTP,
                        Email = request.Email.Trim(),
                        PostalCode = request.KodePosKTP.Trim(),
                        Idprovince = GetProvinceKTP,
                        Idcountry = await boReference.GetDataByDisplay(request.NegaraKTP.Trim(), "Negara") ?? "ID",
                        Phone = request.NoTelepon.Trim(),
                        MobilePhone = request.NoHP.Trim(),
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim(),
                        SysActionType = "I",
                        SysRecStatus = true,
                        SysApprovalStatus = 1,
                        SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                        IsPriority = true,
                        StatementType = 0,
                    });

                    TCus.TcustomerAddresses.Add(new TcustomerAddress
                    {
                        Address1 = request.AlamatTinggal.Trim(),
                        AddressTypeCode = "1",
                        FullName = (request.NamaDepan.Trim() ?? "") + " " + (request.NamaTengah.Trim() ?? "") + " " + (request.NamaBelakang.Trim() ?? ""),
                        City = GetKotaTinggal,
                        Email = request.Email.Trim(),
                        PostalCode = request.KodePosTinggal.Trim(),
                        Idprovince = GetProvinceTinggal,
                        Idcountry = await boReference.GetDataByDisplay(request.NegaraTinggal.Trim(), "Negara") ?? "ID",
                        Phone = request.NoTelepon.Trim(),
                        MobilePhone = request.NoHP.Trim(),
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim(),
                        SysActionType = "I",
                        SysRecStatus = true,
                        SysApprovalStatus = 1,
                        SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                        IsPriority = false,
                        StatementType = 0,
                    });

                    TCus.TagentCustomers.Add(new TagentCustomer
                    {
                        EffDate = DateTime.Now,
                        AgentTreeCode = existAgentStructureTreeCode2.TreeCode2,
                        CustomerTreeCode = null,
                        AgentId = dataAgent.AgentId,
                        IsIncludeAum = null,
                        RecCreated = DateTime.Now,
                        RecCreator = request.ChannelID,
                        SysCreatedBy = request.ChannelID,
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID,
                        SysActionType = "I",
                        SysApprovalStatus = 1,
                        SysRecStatus = true,
                        SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        SysApprovedBy = request.ChannelID,
                        SysApprovedHost = request.ChannelID,
                    });

                    TCus.TcustomerHeirs.Add(new TcustomerHeir
                    {
                        Name = request.NamaAhliwaris.Trim(),
                        Address = "",
                        IdentityType = "",
                        IdentityNumber = "",
                        Relationship = GetHubunganAhliWaris,
                        SysCreatedBy = request.ChannelID.Trim(),
                        SysCreatedTime = DateTime.Now,
                        SysCreatedHost = request.ChannelID.Trim(),
                        SysActionType = "I",
                        SysApprovalStatus = 1,
                        SysRecStatus = true,
                        SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                        SysApprovedBy = request.ChannelID.Trim(),
                        SysApprovedTime = DateTime.Now,
                        SysApprovedHost = request.ChannelID.Trim(),
                    });

                    foreach (var item in request.bankAccounts)
                    {
                        item.IDCabang = await dbContext.TrefBankBranches.Where(x => x.BranchCode.Equals(item.BankCode)).Select(x => x.IdbankBranch).FirstOrDefaultAsync();

                        TCus.TcustBankAccounts.Add(new TcustBankAccount
                        {
                            AccountNo = item.NoRekening.Trim(),
                            AccountName = item.NamaRekening.Trim(),
                            IdaccountBankType = 11,
                            IdbankBranch = item.IDCabang,
                            Idcurrency = 1,
                            SysActionType = "I",
                            SysCreatedBy = request.ChannelID.Trim(),
                            SysCreatedTime = DateTime.Now,
                            SysCreatedHost = request.ChannelID.Trim(),
                            SysRecStatus = true,
                            SysApprovalStatus = 1,
                            SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                            SysApprovedBy = request.ChannelID.Trim(),
                            SysApprovedTime = DateTime.Now,
                            SysApprovedHost = request.ChannelID.Trim(),
                            CreatedBy = request.ChannelID.Trim(),
                            CreatedDate = DateTime.Now,
                        });
                    }

                    await dbContext.AddAsync(TCus);
                    await dbContext.SaveChangesAsync();

                    Tcustomer? resultDataCustomer = await boReference.GetDataCustomerByIDNumberV2(request.NomorIdentitas.Trim(), request.ChannelID.Trim());

                    if (resultDataCustomer is not null)
                    {
                        TcustomerRiskProfile customerRiskProfile = new()
                        {
                            Idcustomer = resultDataCustomer.Idcustomer,
                            EffectiveDate = DateTime.Now,
                            ExpireDate = DateTime.Parse("9999-12-31"),
                            SysCreatedBy = request.ChannelID.Trim(),
                            SysCreatedTime = DateTime.Now,
                            SysCreatedHost = request.ChannelID.Trim(),
                            SysActionType = "I",
                            SysApprovalStatus = 1,
                            SysRecStatus = true,
                            SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                            SysApprovedBy = request.ChannelID.Trim(),
                            SysApprovedTime = DateTime.Now,
                            SysApprovedHost = request.ChannelID.Trim(),
                        };

                        foreach (var item in request.ListQuestionnaire)
                        {
                            if (item.Type.Equals("RISK"))
                            {
                                tempQuestionID = await boReference.CheckQuestionRiskProfile(item.QuestionNo);
                                tempQuestionOptionID = await boReference.CheckAnswerRiskProfile(tempQuestionID, item.Answer);
                                customerRiskProfile.TcustomerRiskProfileAnswers.Add(new TcustomerRiskProfileAnswer()
                                {
                                    QuestionId = tempQuestionID,
                                    QuestionOptionId = tempQuestionOptionID,
                                    SysCreatedBy = request.ChannelID.Trim(),
                                    SysCreatedTime = DateTime.Now,
                                    SysCreatedHost = request.ChannelID.Trim(),
                                    SysActionType = "I",
                                    SysApprovalStatus = 1,
                                    SysRecStatus = true,
                                    SysApprovalNotes = "Imported From @@" + request.ChannelID.Trim() + "@@",
                                    SysApprovedBy = request.ChannelID.Trim(),
                                    SysApprovedTime = DateTime.Now,
                                    SysApprovedHost = request.ChannelID.Trim(),
                                });
                            }
                        }

                        await dbContext.AddAsync(customerRiskProfile);
                        await dbContext.SaveChangesAsync();

                        result.Data.CustomerID = TCus.Idcustomer;
                        result.Data.CIF = TCus.UnitHolderIdno;
                        result.Data.RiskProfileID = customerRiskProfile.ProfileId;
                        string? profileName = await boReference.GetDataRiskProfileName(customerRiskProfile.ProfileId);
                        result.Data.RiskProfileName = profileName;
                    }
                }
                
                if (request.ActionType.Equals("U"))
                {
                    dataCustomer = await boReference.GetDataCustomer(request.CIF.Trim(), request.NomorIdentitas.Trim(), request.ChannelID.Trim());
                    if (dataCustomer is not null)
                    {
                        TcustomerRiskProfile? dataExistCustRiskProfile = await boReference.GetDataRiskProfile(dataCustomer.Idcustomer);
                        if (dataExistCustRiskProfile is not null)
                        {
                            List<TcustomerRiskProfileAnswer> dataExistCustRiskProfileAnswer = await boReference.GetDataRiskProfileAnswer(dataExistCustRiskProfile.TcustomerRiskProfileId);
                            if (dataExistCustRiskProfileAnswer.Count > 0)
                            {
                                dbContext.TcustomerRiskProfileAnswers.RemoveRange(dataExistCustRiskProfileAnswer);
                                await dbContext.SaveChangesAsync();
                            }
                                

                            dbContext.TcustomerRiskProfiles.RemoveRange(dataExistCustRiskProfile);
                            await dbContext.SaveChangesAsync();

                            TcustomerRiskProfile customerRiskProfile = new()
                            {
                                Idcustomer = dataCustomer.Idcustomer,
                                EffectiveDate = DateTime.Now,
                                ExpireDate = DateTime.Parse("9999-12-31"),
                                SysCreatedBy = request.ChannelID.Trim(),
                                SysCreatedTime = dataExistCustRiskProfile.SysCreatedTime,
                                SysCreatedHost = request.ChannelID.Trim(),
                                SysModifiedBy = request.ChannelID.Trim(),
                                SysModifiedTime = DateTime.Now,
                                SysModifiedHost = request.ChannelID.Trim(),
                                SysActionType = "U",
                                SysApprovalStatus = 1,
                                SysRecStatus = true,
                                SysApprovalNotes = "Updated From @@" + request.ChannelID.Trim() + "@@",
                                SysApprovedBy = request.ChannelID.Trim(),
                                SysApprovedTime = DateTime.Now,
                                SysApprovedHost = request.ChannelID.Trim(),
                            };

                            foreach (var item in request.ListQuestionnaire)
                            {
                                if (item.Type.Equals("RISK"))
                                {
                                    tempQuestionID = await boReference.CheckQuestionRiskProfile(item.QuestionNo);
                                    tempQuestionOptionID = await boReference.CheckAnswerRiskProfile(tempQuestionID, item.Answer);
                                    customerRiskProfile.TcustomerRiskProfileAnswers.Add(new TcustomerRiskProfileAnswer()
                                    {
                                        QuestionId = tempQuestionID,
                                        QuestionOptionId = tempQuestionOptionID,
                                        SysCreatedBy = request.ChannelID.Trim(),
                                        SysCreatedTime = DateTime.Now,
                                        SysCreatedHost = request.ChannelID.Trim(),
                                        SysModifiedBy = request.ChannelID.Trim(),
                                        SysModifiedTime = DateTime.Now,
                                        SysModifiedHost = request.ChannelID.Trim(),
                                        SysActionType = "U",
                                        SysApprovalStatus = 1,
                                        SysRecStatus = true,
                                        SysApprovalNotes = "Updated From @@" + request.ChannelID.Trim() + "@@",
                                        SysApprovedBy = request.ChannelID.Trim(),
                                        SysApprovedTime = DateTime.Now,
                                        SysApprovedHost = request.ChannelID.Trim(),
                                    });
                                }
                            }
                            await dbContext.AddAsync(customerRiskProfile);
                            await dbContext.SaveChangesAsync();

                            result.Data.CustomerID = dataCustomer.Idcustomer;
                            result.Data.CIF = dataCustomer.UnitHolderIdno;
                            result.Data.RiskProfileID = customerRiskProfile.ProfileId;
                            string? profileName = await boReference.GetDataRiskProfileName(customerRiskProfile.ProfileId);
                            result.Data.RiskProfileName = profileName;
                        }
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Risk Profile", "RiskProfile", "", null,
                                    request.CIF.Trim(), JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }

            return result;
        }
    }
}
