using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TbancAssuranceBalanceMpp
    {
        public long TbancAssuranceBalanceMppid { get; set; }
        public string? NoPolis { get; set; }
        public long? Idproduct { get; set; }
        public string? ProductName { get; set; }
        public string? Cif { get; set; }
        public string? DebitAccount { get; set; }
        public string? NoHp { get; set; }
        public string? Address { get; set; }
        public string? PolicyHolder { get; set; }
        public string? InsuredPerson { get; set; }
        public string? PolicyStatus { get; set; }
        public double? PremiDasar { get; set; }
        public DateTime? IssuedDate { get; set; }
        public double? SumInsured { get; set; }
        public string? InsurableInterest { get; set; }
        public string? BeneficialOwner { get; set; }
        public int? InsuredAge { get; set; }
        public string? PolicyAge { get; set; }
        public short? PaymentTenor { get; set; }
        public string? PaymentMethode { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public double? TotalTunggakanBilling { get; set; }
        public string? KodeCabang { get; set; }
        public string? NamaSeller { get; set; }
        public string? KodeSeller { get; set; }
        public string? Regional { get; set; }
        public string? Area { get; set; }
        public string? Cabang { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public string SysActionType { get; set; } = null!;
        public byte SysApprovalStatus { get; set; }
        public bool? SysRecStatus { get; set; }
        public string? SysPendingBy { get; set; }
        public DateTime? SysPendingTime { get; set; }
        public string? SysPendingHost { get; set; }
        public string? SysApprovalNotes { get; set; }
        public string? SysApprovedBy { get; set; }
        public DateTime? SysApprovedTime { get; set; }
        public string? SysApprovedHost { get; set; }
        public string? SysDeletedBy { get; set; }
        public DateTime? SysDeletedTime { get; set; }
        public string? SyDeletedHost { get; set; }
        public double? TotalPembayaranPremi { get; set; }
    }
}
