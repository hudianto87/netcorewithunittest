using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuipendTcustomerAddress
    {
        public long IdcustomerAddress { get; set; }
        public long? Idcustomer { get; set; }
        public string? AddressTypeCode { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Address5 { get; set; }
        public string? City { get; set; }
        public string? Idcountry { get; set; }
        public string? Idprovince { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public string? FullName { get; set; }
        public string? Neighborhood { get; set; }
        public string? District { get; set; }
        public string? SubDistrict { get; set; }
        public string? PhoneExtension { get; set; }
        public string? Remarks { get; set; }
        public string? MobilePhone2 { get; set; }
        public string? OwnershipStatusCode { get; set; }
        public string? OwnershipStatusOthers { get; set; }
        public int? YearsOfCurrentAddress { get; set; }
        public int? MonthOfCurrentAddress { get; set; }
        public string? DistanceToBranchCode { get; set; }
        public bool? IsPriority { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public string? SysActionType { get; set; }
        public byte? SysApprovalStatus { get; set; }
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
        public int? StatementType { get; set; }
    }
}
