using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRInstallmentRegister
    {
        public string CIF { get; set; }
        public string ProductCode { get; set; }
        public string CustomerAccountNo { get; set; }
        public double Amount { get; set; }
        public double FeeAmount { get; set; }
        public double TaxAmount { get; set; }
        public double NetAmount { get; set; }
        public int Tenor { get; set; }
        public int CycleDate { get; set; }
        public string Planning { get; set; }
        public string RefNo { get; set; }
        public long RegisterID { get; set; }
        public string FirstDebit { get; set; }

}
}
