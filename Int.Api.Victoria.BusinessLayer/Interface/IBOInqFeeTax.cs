using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.DataAccess.Models;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    interface IBOInqFeeTax
    {
        Task<ResultBase<BMRInqFeeTax>> ProcessInquiryFeeTax(BMInqFeeTax requestFeeTax);
        double BuildAmount(double value, int digit);
        Task<List<Ttransaction>> GetTransactionsRedBeforeAppBySubAcc(long iDSubAccount, long iDProduct, DateTime beginDate, DateTime endDate);
        ValueTask<double> GetDataNAV(long idProduct);
        ValueTask<double> GetProductTransactionFeePercent(short channelID, string productCode, string transactionCategory);
    }
}
