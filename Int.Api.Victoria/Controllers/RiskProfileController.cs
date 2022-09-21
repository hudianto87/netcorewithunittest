using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskProfileController : ControllerBase
    {
        private readonly BORiskProfile boRiskProfile;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public RiskProfileController(DBContext db)
        {
            boRiskProfile = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRRiskProfile>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRRiskProfile>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRRiskProfile>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRRiskProfile>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRRiskProfile>), 422)]
        public async Task<IActionResult> ProcessRiskProfile(BMRiskProfile request)
        {
            var finalResult = await boRiskProfile.ProcessRiskProfile(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
