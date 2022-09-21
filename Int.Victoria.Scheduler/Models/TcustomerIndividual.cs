using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TcustomerIndividual
    {
        public long Idcustomer { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? TempatLahir { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public int? JenisKelaminId { get; set; }
        public int? AgamaId { get; set; }
        public int? StatusPernikahanId { get; set; }
        public string? NoId { get; set; }
        public DateTime? TanggalKadaluarsaId { get; set; }
        public string? Npwp { get; set; }
        public DateTime? TanggalRegistrasi { get; set; }
        public int? KewarganegaraanId { get; set; }
        public string? NationalityOther { get; set; }
        public string? NamaIbuKandungSebelumMenikah { get; set; }
        public string? HeirName1 { get; set; }
        public string? HeirName2 { get; set; }
        public string? HeirName3 { get; set; }
        public string? HeirName4 { get; set; }
        public string? HeirName1Relation { get; set; }
        public string? HeirName2Relation { get; set; }
        public string? HeirName3Relation { get; set; }
        public string? HeirName4Relation { get; set; }
        public int? NumberOfDependent { get; set; }
        public int? PendidikanId { get; set; }
        public string? PendidikanText { get; set; }
        public string? NoTelpRumah { get; set; }
        public string? NoHp { get; set; }
        public string? NoFax { get; set; }
        public string? EmailPribadi { get; set; }
        public string? AlamatById { get; set; }
        public string? RtrwbyId { get; set; }
        public int? CityIdbyId { get; set; }
        public string? KodePosById { get; set; }
        public string? AlamatByStay { get; set; }
        public string? RtRwByStay { get; set; }
        public int? CityIdbyStay { get; set; }
        public string? KodePosByStay { get; set; }
        public int? ResidenceStatusId { get; set; }
        public decimal? OccupiedDuration { get; set; }
        public int? AlamatKorespondenId { get; set; }
        public string? CorrespondentAddress { get; set; }
        public string? CorrespondentRtrw { get; set; }
        public int? CorrespondentCityId { get; set; }
        public string? CorrespondentZipCode { get; set; }
        public long? AlamatKonfirmasiId { get; set; }
        public string? Nik { get; set; }
        public int? Idtype { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
