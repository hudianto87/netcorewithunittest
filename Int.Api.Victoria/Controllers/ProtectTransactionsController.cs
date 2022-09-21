using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Microsoft.AspNetCore.Mvc;

namespace Int.Api.Victoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectTransactionsController : ControllerBase
    {
        private readonly BOProtectTransactions boProtectTransactions;
        public ProtectTransactionsController(DBContext db)
        {
            boProtectTransactions = new(db);
        }
        [HttpPost]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ResultBase<BMRProtectTransactions>), 200)]
        [ProducesResponseType(typeof(ResultBase<BMRProtectTransactions>), 400)]
        [ProducesResponseType(typeof(ResultBase<BMRProtectTransactions>), 404)]
        [ProducesResponseType(typeof(ResultBase<BMRProtectTransactions>), 500)]
        [ProducesResponseType(typeof(ResultBase<BMRProtectTransactions>), 422)]
        public async Task<IActionResult> ProtectTransactions(BMProtectTransactions request)
        {
            var finalResult = await boProtectTransactions.ProcessProtectTransactions(request);
            if (!finalResult.IsOk)
                return BadRequest(finalResult);

            return Ok(finalResult);
        }
    }
}
