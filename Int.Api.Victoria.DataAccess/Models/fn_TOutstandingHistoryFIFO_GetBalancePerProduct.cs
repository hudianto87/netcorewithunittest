using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.DataAccess.Models
{
    public class fn_TOutstandingHistoryFIFO_GetBalancePerProduct
    {
        public long IDCustomer { get; set; }
        public long IDProduct { get; set; }
        public long IDSubAccount { get; set; }
        public DateTime OutstandingDate { get; set; }
        public double BalanceUnit { get; set; }
        public double AvgUnitCost { get; set; }
        public string NoAccount { get; set; }
    }
}
