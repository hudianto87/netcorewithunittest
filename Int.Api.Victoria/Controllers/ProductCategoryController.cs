using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly BOProductCategory boProductCategory;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ProductCategoryController(DBContext db)
        {
            boProductCategory = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCategory>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCategory>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCategory>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCategory>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCategory>), 422)]
        public async Task<IActionResult> InquiryProductCategory(BMProductCategory request)
        {
            var finalResult = await boProductCategory.ResultProductCategory(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
