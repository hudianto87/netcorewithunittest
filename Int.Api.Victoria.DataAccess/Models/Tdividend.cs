using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Tdividend
    {
        public Tdividend()
        {
            TdividendSaldos = new HashSet<TdividendSaldo>();
        }

        public string ProductCode { get; set; } = null!;
        public DateTime DividendDate { get; set; }
        public DateTime? Navdate { get; set; }
        public double? NavValue { get; set; }
        public double? Epu { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string? IsProcessedYn { get; set; }
        public string? ProcessUser { get; set; }
        public DateTime? ProcessDate { get; set; }
        public decimal DividendId { get; set; }
        public DateTime? DateOpen { get; set; }
        public decimal? DividendRate { get; set; }
        public decimal? OutstandingUnits { get; set; }
        public decimal? DividendUnits { get; set; }
        public decimal? DividendAmount { get; set; }
        public decimal? Currency { get; set; }
        public DateTime? XDate { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public decimal? BatchId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Guid? Rowguid { get; set; }

        public virtual ICollection<TdividendSaldo> TdividendSaldos { get; set; }
    }
}
