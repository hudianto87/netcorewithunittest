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
    public class TransactionController : ControllerBase
    {
        private readonly BOTransaction boTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public TransactionController(DBContext db)
        {
            boTransaction = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRTransaction>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRTransaction>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRTransaction>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRTransaction>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRTransaction>), 422)]
        public async Task<IActionResult> ProcessTransaction(BMTransaction request)
        {
            var finalResult = await boTransaction.ProcessTransactions(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
