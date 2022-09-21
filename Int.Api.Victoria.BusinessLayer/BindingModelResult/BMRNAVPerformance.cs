using System.ComponentModel.DataAnnotations;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRNAVPerformance
    {
        public List<NAVPerformance> Performances { get; set; } = new List<NAVPerformance>();
    }
    public class NAVPerformance
    {
        [Required] public DateTime Date { get; set; }
        [Required] public double Amount { get; set; }
    }
}
