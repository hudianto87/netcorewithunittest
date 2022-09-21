using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    interface IBORiskProfile
    {
        Task<ResultBase<BMRRiskProfile>> ProcessRiskProfile(BMRiskProfile request);
    }
}
