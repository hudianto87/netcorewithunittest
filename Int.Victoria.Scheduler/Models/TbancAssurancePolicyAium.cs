using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TbancAssurancePolicyAium
    {
        public int IdbancAssurancePolicyAia { get; set; }
        public string? KodeCabangRef { get; set; }
        public string? NamaCabangRef { get; set; }
        public string? ClientRef { get; set; }
        public string? NiksalesSode { get; set; }
        public string? KodeRef { get; set; }
        public string? NamaRef { get; set; }
        public string? LevelRef { get; set; }
        public string? Distrik { get; set; }
        public string? KodeCabang { get; set; }
        public string? NamaCabang { get; set; }
        public string? ClientFa { get; set; }
        public string? KodeFa { get; set; }
        public string? NamaFa { get; set; }
        public string? Level { get; set; }
        public DateTime? Tmk { get; set; }
        public string? KodeSpv { get; set; }
        public string PolisNo { get; set; } = null!;
        public string? NoSp { get; set; }
        public string? NamaPemegangPolis { get; set; }
        public string? NamaTertanggung { get; set; }
        public string? Status { get; set; }
        public DateTime? EntrySpdate { get; set; }
        public DateTime? ApprovedSpdate { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? Rcddate { get; set; }
        public DateTime? Ptddate { get; set; }
        public DateTime? ProposedDate { get; set; }
        public string? Mtu { get; set; }
        public string? Kurs { get; set; }
        public double? BasicPremi { get; set; }
        public double? Rider { get; set; }
        public double? SingleTopUp { get; set; }
        public double? Premi { get; set; }
        public double? Anp { get; set; }
        public double? TopUpBasic { get; set; }
        public double? Unit { get; set; }
        public string? PaymentFrequency { get; set; }
        public string? CaraBayar { get; set; }
        public string? ProductName { get; set; }
        public string? PolicyPlan { get; set; }
        public string? NoCin { get; set; }
        public string? AreaName { get; set; }
        public string? Bbcpolis { get; set; }
        public string? Bbcname { get; set; }
        public string? InitialBranch { get; set; }
        public DateTime? StatusSurrenderDate { get; set; }
        public string? Rekening { get; set; }
        public string? NoRekening { get; set; }
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? Keterangan { get; set; }
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
        public string? SysDeletedHost { get; set; }
    }
}
