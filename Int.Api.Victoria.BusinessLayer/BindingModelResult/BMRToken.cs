using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRToken
    {
        [Required] public string Token { get; set; } = string.Empty;
    }
}
