using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    interface IBOProtectTransactions
    {
        Task<ResultBase<BMRProtectTransactions>> ProcessProtectTransactions(BMProtectTransactions request);
    }
}
