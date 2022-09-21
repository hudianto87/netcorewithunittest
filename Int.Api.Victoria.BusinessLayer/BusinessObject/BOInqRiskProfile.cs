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
    public class BOInqRiskProfile : IBOInqRiskProfile
    {
        private readonly DBContext dBContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode = new();
        private readonly BOLogger boLogger;
        public BOInqRiskProfile(DBContext dB)
        {
            dBContext = dB;
            boReference = new Reference(dBContext);
            boLogger = new(dB);
        }
        public async Task<ResultBase<BMRInqRiskProfile>> GetRiskProfile(BMInqRiskProfile bmInqRiskProfile)
        {
            var result = new ResultBase<BMRInqRiskProfile>();

            try
            {
                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new VTreferenceDetail();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(bmInqRiskProfile.ChannelID)).FirstOrDefault();
                }

                if (getDataChannel == null || DataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                Tcustomer? getDataCustomer = await boReference.GetCustomerByCif(bmInqRiskProfile.CIF.Trim());
                if (getDataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }

                var getDataRiskProfile = await (from TCRP in dBContext.TcustomerRiskProfiles.DefaultIfEmpty()
                                                join TRP in dBContext.TrefProfiles.DefaultIfEmpty() on TCRP.ProfileId equals TRP.ProfileId
                                                where TCRP.Idcustomer == getDataCustomer.Idcustomer
                                                select new 
                                                {
                                                    TCRP.ProfileId,
                                                    TCRP.ExpireDate,
                                                    TRP.ProfileName
                                                }).FirstOrDefaultAsync();
                                                
                if (getDataRiskProfile == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS017);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS017.ToString();
                    return result;
                }
                result.Data = new BMRInqRiskProfile
                {
                    CIF = bmInqRiskProfile.CIF.Trim(),
                    RiskProfileID = getDataRiskProfile.ProfileId.ToString() ?? "",
                    RiskProfileName = getDataRiskProfile.ProfileName ?? "",
                    RiskProfileExpDt = getDataRiskProfile.ExpireDate.ToString("yyyy-MM-dd") ?? "",
                    SIDMF = getDataCustomer.Sid ?? ""
                };

                if (string.IsNullOrEmpty(result.Data.SIDMF))
                    result.Data.SIDMFProcessStatus = false;
                else
                    result.Data.SIDMFProcessStatus = true;

                result.Data.IFUA = getDataCustomer.FundUnitAccount ?? "";
            }
            catch (Exception ex)
            {
                result.IsOk=false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", bmInqRiskProfile.ChannelID.Trim(), "Service Inquiry Risk Profile", "InqRiskProfile", "", null,
                                    bmInqRiskProfile.CIF.Trim(), JsonConvert.SerializeObject(bmInqRiskProfile), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, bmInqRiskProfile.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}