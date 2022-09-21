using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InqCustBankAccountController : ControllerBase
    {
        private readonly BOCustBankAccount boCustBankAccount;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public InqCustBankAccountController(DBContext dbContext)
        {
            boCustBankAccount = new BOCustBankAccount(dbContext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestCustBankAccount"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRInqCustBankAccount>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRInqCustBankAccount>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRInqCustBankAccount>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRInqCustBankAccount>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRInqCustBankAccount>), 422)]
        public async Task<IActionResult> GetCustBankAccount(BMInqCustBankAccount requestCustBankAccount)
        {
            try
            {
                var finalResult = await boCustBankAccount.GetBankAccount(requestCustBankAccount);
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
