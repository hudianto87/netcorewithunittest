using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InqFeeTaxController : ControllerBase
    {
        private readonly BOInqFeeTax boInqFeeTax;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public InqFeeTaxController(DBContext db)
        {
            boInqFeeTax = new BOInqFeeTax(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestInqFeeTax"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRInqFeeTax>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRInqFeeTax>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRInqFeeTax>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRInqFeeTax>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRInqFeeTax>), 422)]
        public async Task<IActionResult> InquiryFeeTax(BMInqFeeTax requestInqFeeTax)
        {
            var finalResult = await boInqFeeTax.ProcessInquiryFeeTax(requestInqFeeTax);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
