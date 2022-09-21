using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NAVPerformanceController : ControllerBase
    {
        private readonly BONavPerformance boNavPerformance;
        public NAVPerformanceController(DBContext db)
        {
            boNavPerformance = new BONavPerformance(db);
        }
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRNAVPerformance>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRNAVPerformance>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRNAVPerformance>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRNAVPerformance>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRNAVPerformance>), 422)]
        public async Task<IActionResult> InquiryNavPerformance(BMNAVPerformance request)
        {
            var finalResult = await boNavPerformance.InquiryNAV(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
