using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TaccStatement
    {
        public DateTime? Date { get; set; }
        public string? UnitHolderIdNo { get; set; }
        public string? FullName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? MailZip { get; set; }
        public string? CodeAgent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Product { get; set; }
        public string? Ccy { get; set; }
        public DateTime? NavdateAkhirBulan { get; set; }
        public double? NavperUnitAkhirBulan { get; set; }
        public double? BalanceUnitAkhirBulan { get; set; }
        public DateTime? TransDate { get; set; }
        public double? NavperUnitTrans { get; set; }
        public string? RefTransNoCustody { get; set; }
        public string? TransTypeIna { get; set; }
        public string? TransTypeEng { get; set; }
        public double? UnitTrans { get; set; }
        public double? UnitBalance { get; set; }
        public string? CodeAgentTrans { get; set; }
        public double? UnitBalanceIdr { get; set; }
    }
}
