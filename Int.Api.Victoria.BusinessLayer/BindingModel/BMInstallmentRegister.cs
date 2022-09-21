using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMInstallmentRegister
    {
        [Required]
        public string ChannelID { get; set; }
        [Required]
        public string CIF { get; set; }
        [Required]
        public string ProductCode { get; set; }
        public string CustomerAccountNo { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public int Tenor { get; set; }
        [Required]
        public int CycleDate { get; set; }
        public string Planning { get; set; }
        [Required]
        public string RefNo { get; set; }
    }
}
