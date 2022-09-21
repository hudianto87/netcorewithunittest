﻿using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TgenuitempTasset
    {
        public long TgenuitempTableId { get; set; }
        public string TgenuitempSessionId { get; set; } = null!;
        public long? TgenuitempIdmaster { get; set; }
        public long? TgenuitempIddetail { get; set; }
        public short TgenuitempChangeFlag { get; set; }
        public string TgenuitempSysCreatedBy { get; set; } = null!;
        public DateTime TgenuitempSysCreatedTime { get; set; }
        public string TgenuitempSysCreatedHost { get; set; } = null!;
        public string? TgenuitempSysModifiedBy { get; set; }
        public DateTime? TgenuitempSysModifiedTime { get; set; }
        public string? TgenuitempSysModifiedHost { get; set; }
        public long? Idasset { get; set; }
        public long? Idcustomer { get; set; }
        public double? Kas1 { get; set; }
        public double? Kas2 { get; set; }
        public double? Kas3 { get; set; }
        public double? Tabungan1 { get; set; }
        public double? Tabungan2 { get; set; }
        public double? Tabungan3 { get; set; }
        public double? Deposito1 { get; set; }
        public double? Deposito2 { get; set; }
        public double? Deposito3 { get; set; }
        public double? AsuransiTunai1 { get; set; }
        public double? AsuransiTunai2 { get; set; }
        public double? AsuransiTunai3 { get; set; }
        public double? Rdpu1 { get; set; }
        public double? Rdpu2 { get; set; }
        public double? Rdpu3 { get; set; }
        public double? UangAsing1 { get; set; }
        public double? UangAsing2 { get; set; }
        public double? UangAsing3 { get; set; }
        public double? Piutang1 { get; set; }
        public double? Piutang2 { get; set; }
        public double? Piutang3 { get; set; }
        public double? KasLainnya1 { get; set; }
        public double? KasLainnya2 { get; set; }
        public double? KasLainnya3 { get; set; }
        public double? TotalAssetKas1 { get; set; }
        public double? TotalAssetKas2 { get; set; }
        public double? TotalAssetKas3 { get; set; }
        public double? Rdpt1 { get; set; }
        public double? Rdpt2 { get; set; }
        public double? Rdpt3 { get; set; }
        public double? Rdc1 { get; set; }
        public double? Rdc2 { get; set; }
        public double? Rdc3 { get; set; }
        public double? Rds1 { get; set; }
        public double? Rds2 { get; set; }
        public double? Rds3 { get; set; }
        public double? Bond1 { get; set; }
        public double? Bond2 { get; set; }
        public double? Bond3 { get; set; }
        public double? Saham1 { get; set; }
        public double? Saham2 { get; set; }
        public double? Saham3 { get; set; }
        public double? UnitLink1 { get; set; }
        public double? UnitLink2 { get; set; }
        public double? UnitLink3 { get; set; }
        public double? Emas1 { get; set; }
        public double? Emas2 { get; set; }
        public double? Emas3 { get; set; }
        public double? MitraUsaha1 { get; set; }
        public double? MitraUsaha2 { get; set; }
        public double? MitraUsaha3 { get; set; }
        public double? InvestasiLainnya1 { get; set; }
        public double? InvestasiLainnya2 { get; set; }
        public double? InvestasiLainnya3 { get; set; }
        public double? TotalAssetInvestasi1 { get; set; }
        public double? TotalAssetInvestasi2 { get; set; }
        public double? TotalAssetInvestasi3 { get; set; }
        public double? Jht1 { get; set; }
        public double? Jht2 { get; set; }
        public double? Jht3 { get; set; }
        public double? Dplk1 { get; set; }
        public double? Dplk2 { get; set; }
        public double? Dplk3 { get; set; }
        public double? RumahSewa1 { get; set; }
        public double? RumahSewa2 { get; set; }
        public double? RumahSewa3 { get; set; }
        public double? ApartementSewa1 { get; set; }
        public double? ApartementSewa2 { get; set; }
        public double? ApartementSewa3 { get; set; }
        public double? Tanah1 { get; set; }
        public double? Tanah2 { get; set; }
        public double? Tanah3 { get; set; }
        public double? KemitraanSaham1 { get; set; }
        public double? KemitraanSaham2 { get; set; }
        public double? KemitraanSaham3 { get; set; }
        public double? Kantor1 { get; set; }
        public double? Kantor2 { get; set; }
        public double? Kantor3 { get; set; }
        public double? KendaraanSewa1 { get; set; }
        public double? KendaraanSewa2 { get; set; }
        public double? KendaraanSewa3 { get; set; }
        public double? InvestasiTidakLancarLainnya1 { get; set; }
        public double? InvestasiTidakLancarLainnya2 { get; set; }
        public double? InvestasiTidakLancarLainnya3 { get; set; }
        public double? TotalAssetTidakLancar1 { get; set; }
        public double? TotalAssetTidakLancar2 { get; set; }
        public double? TotalAssetTidakLancar3 { get; set; }
        public double? Perhiasan1 { get; set; }
        public double? Perhiasan2 { get; set; }
        public double? Perhiasan3 { get; set; }
        public double? Koleksi1 { get; set; }
        public double? Koleksi2 { get; set; }
        public double? Koleksi3 { get; set; }
        public double? Rumah1 { get; set; }
        public double? Rumah2 { get; set; }
        public double? Rumah3 { get; set; }
        public double? Apartement1 { get; set; }
        public double? Apartement2 { get; set; }
        public double? Apartement3 { get; set; }
        public double? Mobil1 { get; set; }
        public double? Mobil2 { get; set; }
        public double? Mobil3 { get; set; }
        public double? Motor1 { get; set; }
        public double? Motor2 { get; set; }
        public double? Motor3 { get; set; }
        public double? AssetKonsumsiLainnya1 { get; set; }
        public double? AssetKonsumsiLainnya2 { get; set; }
        public double? AssetKonsumsiLainnya3 { get; set; }
        public double? TotalAssetKonsumsi1 { get; set; }
        public double? TotalAssetKonsumsi2 { get; set; }
        public double? TotalAssetKonsumsi3 { get; set; }
        public double? TotalAsset1 { get; set; }
        public double? TotalAsset2 { get; set; }
        public double? TotalAsset3 { get; set; }
        public double? KartuKredit1 { get; set; }
        public double? KartuKredit2 { get; set; }
        public double? KartuKredit3 { get; set; }
        public double? KreditPribadi1 { get; set; }
        public double? KreditPribadi2 { get; set; }
        public double? KreditPribadi3 { get; set; }
        public double? PinjamanKta1 { get; set; }
        public double? PinjamanKta2 { get; set; }
        public double? PinjamanKta3 { get; set; }
        public double? Cicilan1 { get; set; }
        public double? Cicilan2 { get; set; }
        public double? Cicilan3 { get; set; }
        public double? Cicilan4 { get; set; }
        public double? Cicilan5 { get; set; }
        public double? Cicilan6 { get; set; }
        public double? PinjamanJangkaPendek1 { get; set; }
        public double? PinjamanJangkaPendek2 { get; set; }
        public double? PinjamanJangkaPendek3 { get; set; }
        public double? TotalKewajibanJangkaPendek1 { get; set; }
        public double? TotalKewajibanJangkaPendek2 { get; set; }
        public double? TotalKewajibanJangkaPendek3 { get; set; }
        public double? KreditKendaraan1 { get; set; }
        public double? KreditKendaraan2 { get; set; }
        public double? KreditKendaraan3 { get; set; }
        public double? KreditRumah1 { get; set; }
        public double? KreditRumah2 { get; set; }
        public double? KreditRumah3 { get; set; }
        public double? KreditApartement1 { get; set; }
        public double? KreditApartement2 { get; set; }
        public double? KreditApartement3 { get; set; }
        public double? PinjamanLunakPerusahaan1 { get; set; }
        public double? PinjamanLunakPerusahaan2 { get; set; }
        public double? PinjamanLunakPerusahaan3 { get; set; }
        public double? PinjamanJangkaPanjangLainnya1 { get; set; }
        public double? PinjamanJangkaPanjangLainnya2 { get; set; }
        public double? PinjamanJangkaPanjangLainnya3 { get; set; }
        public double? TotalKewajibanJangkaPanjang1 { get; set; }
        public double? TotalKewajibanJangkaPanjang2 { get; set; }
        public double? TotalKewajibanJangkaPanjang3 { get; set; }
        public double? TotalKewajiban1 { get; set; }
        public double? TotalKewajiban2 { get; set; }
        public double? TotalKewajiban3 { get; set; }
        public double? NetWorth { get; set; }
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
    }
}
