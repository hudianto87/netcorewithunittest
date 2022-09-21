using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly BOToken boToken;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="dbContext"></param>
        public TokenController(IConfiguration configuration, DBContext dbContext) => boToken = new(configuration, dbContext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRToken>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRToken>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRToken>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRToken>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRToken>), 422)]
        public async Task<IActionResult> GenerateToken(BMToken request)
        {
            var finalResult = await boToken.GenerateToken(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
