using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.DataAccess.Models;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    internal interface IBOTransactions
    {
        Task<ResultBase<BMRTransaction>> ProcessTransactions(BMTransaction requestTransaction);
        Task<(bool, long)> InsertTransactionData(Ttransaction ttransaction);
        Task<bool> InsertTtransactionNotification(TtransactionNotification ttransactionNotification);
    }
}
