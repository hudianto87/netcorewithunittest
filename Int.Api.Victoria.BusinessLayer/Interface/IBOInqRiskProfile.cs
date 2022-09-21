using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    interface IBOInqRiskProfile
    {
        Task<ResultBase<BMRInqRiskProfile>> GetRiskProfile(BMInqRiskProfile bmInqRiskProfile);
    }
}
