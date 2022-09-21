namespace Int.Api.Victoria.DataAccess.Models
{
    public class fn_TOutstandingHistoryFIFO_GetBalancePerSubAccount_Result
    {
        public long IDCustomer { get; set; }
        public long IDProduct { get; set; }
        public long IdSubAccount { get; set; }
        public DateTime? OutstandingDate { get; set; }
        public double? BalanceUnit { get; set; }
        public double? AvgUnitCost { get; set; }
    }
}
