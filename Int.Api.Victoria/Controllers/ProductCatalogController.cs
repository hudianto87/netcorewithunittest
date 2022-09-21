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
    public class ProductCatalogController : ControllerBase
    {
        private readonly BOProductCatalog boProductCatalog;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public ProductCatalogController(DBContext db)
        {
            boProductCatalog = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCatalog>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCatalog>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCatalog>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCatalog>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRProductCatalog>), 422)]
        public async Task<IActionResult> InquiryProductCatalog(BMProductCatalog request)
        {
            var finalResult = await boProductCatalog.InqProductCatalog(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
