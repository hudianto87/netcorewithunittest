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
    public class CustomerPortfolioController : ControllerBase
    {
        private readonly BOCustomerPortfolio boCustomerPortfolio;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public CustomerPortfolioController(DBContext db)
        {
            boCustomerPortfolio = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRCustomerPortfolio>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRCustomerPortfolio>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRCustomerPortfolio>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRCustomerPortfolio>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRCustomerPortfolio>), 422)]
        public async Task<IActionResult> ProcessGetDataCustomerPortfolio(BMCustomerPortfolio request)
        {
            var finalResult = await boCustomerPortfolio.GetDataCustomerPortfolio(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
