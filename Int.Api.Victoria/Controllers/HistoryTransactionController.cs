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
    public class HistoryTransactionController : ControllerBase
    {
        private readonly BOHistoryTransaction boHistoryTransaction;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        public HistoryTransactionController(DBContext db)
        {
            boHistoryTransaction = new(db);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRHistoryTransaction>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRHistoryTransaction>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRHistoryTransaction>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRHistoryTransaction>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRHistoryTransaction>), 422)]
        public async Task<IActionResult> InquiryHistoryTransaction(BMHistoryTransaction request)
        {
            var finalResult = await boHistoryTransaction.InquiryTransaction(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
