using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class VCustomerInquiry
    {
        public long Idcustomer { get; set; }
        public string Cif { get; set; } = null!;
        public string UnitHolderIdno { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Status { get; set; }
        public DateTime? BirthDate { get; set; }
        public string InvestorType { get; set; } = null!;
        public string? NoKtp { get; set; }
        public string? Npwp { get; set; }
        public string? SellerCode { get; set; }
        public string? SellerName { get; set; }
        public string? ParentSellerCode { get; set; }
        public string? ParentSellerName { get; set; }
        public DateTime? OpenigDate { get; set; }
        public string EntryUser { get; set; } = null!;
        public DateTime EntryDate { get; set; }
        public string? EditUser { get; set; }
        public DateTime? EditDate { get; set; }
        public string? ApproveUser { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? Sid { get; set; }
        public int Unit { get; set; }
        public string BalanceStatus { get; set; } = null!;
        public string? ReferenceNo { get; set; }
        public string? ExternalUnitHolder { get; set; }
        public string? FundUnitAccount { get; set; }
    }
}
