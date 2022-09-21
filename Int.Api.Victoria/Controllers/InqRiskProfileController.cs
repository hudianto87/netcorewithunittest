using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InqRiskProfileController : ControllerBase
    {
        private readonly BOInqRiskProfile boInqRiskProfile;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public InqRiskProfileController(DBContext dbContext)
        {
            boInqRiskProfile = new BOInqRiskProfile(dbContext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bMInqRiskProfile"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRInqRiskProfile>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRInqRiskProfile>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRInqRiskProfile>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRInqRiskProfile>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRInqRiskProfile>), 422)]
        public async Task<IActionResult> GetDataRiskProfile(BMInqRiskProfile bMInqRiskProfile)
        {
            try
            {
                var finalResult = await boInqRiskProfile.GetRiskProfile(bMInqRiskProfile);
                if (!finalResult.IsOk)
                    return BadRequest(finalResult);

                return Ok(finalResult);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
