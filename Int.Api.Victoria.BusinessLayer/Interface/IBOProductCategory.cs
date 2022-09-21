using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.BusinessLayer.Interface
{
    internal interface IBOProductCategory
    {
        Task<ResultBase<List<BMRProductCategory>>> ResultProductCategory(BMProductCategory request);
    }
}
