using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    internal interface IBOHistoryTransaction
    {
        Task<ResultBase<List<BMRHistoryTransaction>>> InquiryTransaction(BMHistoryTransaction request);
    }
}
