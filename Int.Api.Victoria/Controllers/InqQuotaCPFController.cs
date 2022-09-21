using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InqQuotaCPFController : ControllerBase
    {
        private readonly BOInqQuotaCPF QuotaCPF;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public InqQuotaCPFController(DBContext db)
        {
            QuotaCPF = new BOInqQuotaCPF(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRInqQuotaCPF>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRInqQuotaCPF>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRInqQuotaCPF>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRInqQuotaCPF>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRInqQuotaCPF>), 422)]
        public async Task<IActionResult> GetQuotaCPF(BMInqQuotaCPF request)
        {
            var finalResult = await QuotaCPF.GetDataQuotaCPF(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
