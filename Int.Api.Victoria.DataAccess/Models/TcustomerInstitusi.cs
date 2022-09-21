using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TcustomerInstitusi
    {
        public long Idcustomer { get; set; }
        public string? BadanHukum { get; set; }
        public int? DomisiliHukumId { get; set; }
        public string? DomisiliHukumText { get; set; }
        public string? Npwp { get; set; }
        public DateTime? TglRegistrasi { get; set; }
        public string? Siup { get; set; }
        public string? NoTdp { get; set; }
        public DateTime? TglRegTdp { get; set; }
        public DateTime? TglRegSkd { get; set; }
        public DateTime? TglBerdiri { get; set; }
        public int? TempatPendirianId { get; set; }
        public string? TempatPendirianText { get; set; }
        public string? AlamatKantorPusat { get; set; }
        public string? RtrwkantorPusat { get; set; }
        public int? KotaKantorPusatId { get; set; }
        public string? KodePosKantorPusat { get; set; }
        public string? AlamatKoresponden { get; set; }
        public int? KotaKorespondenId { get; set; }
        public string? Rtrwkoresponden { get; set; }
        public string? KodePosKoresponden { get; set; }
        public string? NoTelp { get; set; }
        public string? NoFax { get; set; }
        public string? AlamatEmail { get; set; }
        public int? StatusGedungKantorPusatId { get; set; }
        public string? StatusGedungKantorPusatText { get; set; }
        public int? LamaMenempati { get; set; }
        public bool? EmailKonfirmasi { get; set; }
        public string? EmailKonfirmasiText { get; set; }
        public bool? FaxKantorKonfirmasi { get; set; }
        public string? FaxKantorKonfirmasiText { get; set; }
        public int? BentukBadanHukumId { get; set; }
        public string? BentukBadanHukumText { get; set; }
        public int? KarakteristikId { get; set; }
        public string? KarakteristikText { get; set; }
        public double? NilaiAsset { get; set; }
        public double? AnnualProfit { get; set; }
        public int? OmzetId { get; set; }
        public long? BidangUsahaId { get; set; }
        public string? BidangUsahaText { get; set; }
        public int? SumberDanaId { get; set; }
        public string? SumberDanaText { get; set; }
        public int? ApresiasiHarga { get; set; }
        public int? Investasi { get; set; }
        public int? Spekulasi { get; set; }
        public int? SumberPendapatan { get; set; }
        public int? LainLain { get; set; }
        public string? LainLainText { get; set; }

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
