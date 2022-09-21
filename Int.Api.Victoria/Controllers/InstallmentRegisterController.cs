using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstallmentRegisterController : ControllerBase
    {
        private readonly DBContext dB;
        private readonly IConfiguration config;
        private readonly BOInstallmentRegister bOInstallmentRegister;

        public InstallmentRegisterController(DBContext dBContext, IConfiguration configuration)
        {
            dB = dBContext;
            config= configuration;
            bOInstallmentRegister = new BOInstallmentRegister(dB,config);
        }

        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRInstallmentRegister>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRInstallmentRegister>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRInstallmentRegister>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRInstallmentRegister>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRInstallmentRegister>), 422)]
        public async Task<IActionResult> InstallmentRegister(BMInstallmentRegister requestInstallmentRegister)
        {
            try
            {
                var finalResult = await bOInstallmentRegister.InstallmentRegister(requestInstallmentRegister);
                if (!finalResult.IsOk)
                    return BadRequest(finalResult);

                return Ok(finalResult);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
