using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOCustBankAccount
    {
        private readonly DBContext dbContext;
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode = new();
        private readonly BOLogger boLogger;
        public BOCustBankAccount(DBContext db)
        {
            dbContext = db;
            boReference = new Reference(dbContext);
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRInqCustBankAccount>> GetBankAccount(BMInqCustBankAccount requestInqCustBankAccount)
        {
            var result = new ResultBase<BMRInqCustBankAccount>
            {
                Data = new()
            };
            result.Data.BankAccounts = new();

            try
            {
                List<BankAccountList> listBankAccount = new();

                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new VTreferenceDetail();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(requestInqCustBankAccount.ChannelID)).FirstOrDefault();
                }                

                if (getDataChannel == null || DataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                Tcustomer? getDataCustomer = await boReference.GetCustomerByCif(requestInqCustBankAccount.CIF.Trim());
                if (getDataCustomer == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS006);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS006.ToString();
                    return result;
                }

                listBankAccount = await (from TCBA in dbContext.TcustBankAccounts.DefaultIfEmpty()
                                         join TRC in dbContext.TrefCurrencies.DefaultIfEmpty() on TCBA.Idcurrency equals TRC.Idcurrency
                                         join TRABT in dbContext.TrefAccountBankTypes.DefaultIfEmpty() on TCBA.IdaccountBankType equals TRABT.IdaccountBankType
                                         join TRB in dbContext.TrefBankBranches.DefaultIfEmpty() on TCBA.IdbankBranch equals TRB.IdbankBranch
                                         join RefBank in dbContext.TrefBanks.DefaultIfEmpty() on TRB.Idbank equals RefBank.Idbank
                                         where TCBA.Idcustomer == getDataCustomer.Idcustomer
                                         select new BankAccountList()
                                         {
                                             AccountNo = TCBA.AccountNo,
                                             AccountName = TCBA.AccountName,
                                             AccountType = TRABT.AccountBankType,
                                             Currency = TRC.CurrencyCode,
                                             BankName = RefBank.BankName,
                                             BranchName = TRB.BranchName
                                         }).ToListAsync();

                if (listBankAccount.Count == 0)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS013);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS013.ToString();
                    return result;
                }

                result.Data.CIF = getDataCustomer.UnitHolderIdno;
                result.Data.BankAccounts.AddRange(listBankAccount);
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", requestInqCustBankAccount.ChannelID.Trim(), "Service Customer Bank Account", "InqCustBankAccount", "", null,
                                    requestInqCustBankAccount.CIF.Trim(), JsonConvert.SerializeObject(requestInqCustBankAccount), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, requestInqCustBankAccount.ChannelID.Trim(), DateTime.Now);
            }

            return result;
        }
    }
}
