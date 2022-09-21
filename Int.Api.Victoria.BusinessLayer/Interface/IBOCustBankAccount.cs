using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    interface IBOCustBankAccount
    {
        Task<ResultBase<BMRInqCustBankAccount>> GetBankAccount(BMInqCustBankAccount requestInqCustBankAccount);
    }
}