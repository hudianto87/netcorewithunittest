﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TgenuihistTcustomer
    {
        public long TgenuihistTableId { get; set; }
        public long TgenuijourTableId { get; set; }
        public bool SysIsAfter { get; set; }
        public long? Idcustomer { get; set; }
        public string? UnitHolderIdno { get; set; }
        public string? ExternalUnitHolder { get; set; }
        public string? ReferenceNo { get; set; }
        public string? InvestorType { get; set; }
        public string? InvestorCategory { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Idnationality { get; set; }
        public string? Npwp { get; set; }
        public string? MotherName { get; set; }
        public string? Idtype { get; set; }
        public string? Idnumber { get; set; }
        public DateTime? Idissue { get; set; }
        public DateTime? Idexpired { get; set; }
        public string? Beneficiaries { get; set; }
        public string? Idoccupation { get; set; }
        public string? NatureOfBusiness { get; set; }
        public string? OfficePhone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Idsponsorship { get; set; }
        public double? MinUnitHold { get; set; }
        public int? MinTimePeriod { get; set; }
        public string? IddividendInvest { get; set; }
        public bool? DocId { get; set; }
        public bool? DocNpwp { get; set; }
        public bool? DocAkta { get; set; }
        public bool? DocNotary { get; set; }
        public bool? DocAttorney { get; set; }
        public DateTime? OpDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? CloseUser { get; set; }
        public string? Source { get; set; }
        public DateTime? SourceDate { get; set; }
        public string? SourceBank { get; set; }
        public string? Idstatus { get; set; }
        public string? CodeDrawer { get; set; }
        public string? Remark { get; set; }
        public string? CompanyType { get; set; }
        public DateTime? EstablishDate { get; set; }
        public string? MobilePhone { get; set; }
        public DateTime? NpwpissuedDate { get; set; }
        public string? ClientGroup { get; set; }
        public int? ProfileId { get; set; }
        public int? ProfileScore { get; set; }
        public string? IncomeCp { get; set; }
        public string? IncomeCi { get; set; }
        public long? ParentIdcustomer { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? BirthPlace { get; set; }
        public string? SecurityAccount { get; set; }
        public string? WebSite { get; set; }
        public string? Pisiup { get; set; }
        public string? IdeductionGroup { get; set; }
        public string? Ideducation { get; set; }
        public string? IdsourceOfFundsGroup { get; set; }
        public string? IdsourceOfFunds { get; set; }
        public string? IdobjectivesGroup { get; set; }
        public string? Idobjectives { get; set; }
        public string? IdincomeGroup { get; set; }
        public string? Idincome { get; set; }
        public string? Idcity1 { get; set; }
        public string? Idcity2 { get; set; }
        public string? IdcharacteristicGroup { get; set; }
        public string? Idcharacteristic { get; set; }
        public string? IdmaritalStatusGroup { get; set; }
        public string? IdmaritalStatus { get; set; }
        public string? IdnationalityAriaGroup { get; set; }
        public string? IdnationalityAria { get; set; }
        public string? IdoccupationAriaGroup { get; set; }
        public string? IdoccupationAria { get; set; }
        public string? IdtypeIdentityGroup { get; set; }
        public string? IdtypeIdentity { get; set; }
        public string? IdcompanyTypeGroup { get; set; }
        public string? IdcompanyType { get; set; }
        public string? IdsexGroup { get; set; }
        public string? Idsex { get; set; }
        public string? IdreligiGroup { get; set; }
        public string? Idreligi { get; set; }
        public string? IddomisiliGroup { get; set; }
        public bool? IsBlocked { get; set; }
        public string? Iddomisili { get; set; }
        public bool? IsAria { get; set; }
        public DateTime? Skdexpired { get; set; }
        public string? Skd { get; set; }
        public string? IdeducationGroup { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public string? CustomerTypeCode { get; set; }
        public string? SpouseName { get; set; }
        public string? Heir { get; set; }
        public string? HeirRelation { get; set; }
        public string? Micode { get; set; }
        public string? LegalDomicile { get; set; }
        public string? CompanyEstablished { get; set; }
        public DateTime? CompanyEstablishedDate { get; set; }
        public string? CompanyCharacteristic { get; set; }
        public string? AssociationArticle { get; set; }
        public string? BusinessRegCerticate { get; set; }
        public string? LatestYearAsset { get; set; }
        public string? SecondLatestYearAsset { get; set; }
        public string? ThirdLatestYearAsset { get; set; }
        public string? LatestYearoOperatingProfit { get; set; }
        public string? SecondLatestYearOperatingProfit { get; set; }
        public string? ThirdLatestYearOperatingProfit { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public string? CustomerNameTrim { get; set; }
        public string? NewCustomerCode { get; set; }
        public string? NickName { get; set; }
        public string? Surname { get; set; }
        public string? IdreligiOtherText { get; set; }
        public int? NumberofDependents { get; set; }
        public int? NumberofDependentsOthers { get; set; }
        public string? IdeducationOtherText { get; set; }
        public string? IdtitleBeforeName { get; set; }
        public string? IdtitleBeforeNameOtherText { get; set; }
        public string? IdtitleAfterName { get; set; }
        public string? IdtitleAfterNameOtherText { get; set; }
        public string? Passport { get; set; }
        public DateTime? PassportRegistrationDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string? KimsorKitas { get; set; }
        public DateTime? KimsorKitasregistrationDate { get; set; }
        public DateTime? KimsorKitasexpiryDate { get; set; }
        public string? Kitap { get; set; }
        public DateTime? KitapregistrationDate { get; set; }
        public DateTime? KitapexpiryDate { get; set; }
        public string? PlaceofEstablishment { get; set; }
        public string? LineofBusiness { get; set; }
        public string? TypeofBusinessOthers { get; set; }
        public string? CharacteristicOthers { get; set; }
        public double? LocalOwnershipPercentage { get; set; }
        public double? ForeignOwnershipPercentage { get; set; }
        public string? NoTdp { get; set; }
        public DateTime? TdpexpiryDate { get; set; }
        public string? TdpissuedAt { get; set; }
        public string? Siup { get; set; }
        public DateTime? SiupexpiryDate { get; set; }
        public string? SiupissuedAt { get; set; }
        public string? SkdissuedAt { get; set; }
        public string? NoIjinPma { get; set; }
        public DateTime? NoIjinPmaexpiryDate { get; set; }
        public string? NoIjinPmaissuedAt { get; set; }
        public string? NoIjinUsahaLain { get; set; }
        public DateTime? NoIjinUsahaLainDate { get; set; }
        public string? DeedofEstablishment { get; set; }
        public DateTime? DeedofEstablishmentDate { get; set; }
        public string? NotaryName { get; set; }
        public string? NotaryAt { get; set; }
        public string? LastAmendementofArticleofAssociationNo { get; set; }
        public DateTime? LastAmendementofArticleofAssociationDate { get; set; }
        public string? NotaryName2 { get; set; }
        public string? NotaryAt2 { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        public string? IdoccupationOther { get; set; }
        public string? Position { get; set; }
        public string? Division { get; set; }
        public double? LengthOfEmployment { get; set; }
        public string? OccupationLineOfBusiness { get; set; }
        public double? CompanyTotalAsset { get; set; }
        public double? TotalSales { get; set; }
        public double? NetProfit { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string? IdincomeAdditional { get; set; }
        public string? IdsourceOfMainIncome { get; set; }
        public string? IdsourceOfMainIncomeOther { get; set; }
        public string? IdsourceAdditionalIncome { get; set; }
        public string? IdsourceAdditionalIncomeOther { get; set; }
        public double? TotalIncome { get; set; }
        public string? IdexpensePerMonth { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName2 { get; set; }
        public string? SpouseBirthPlace { get; set; }
        public DateTime? SpouseBirthDate { get; set; }
        public string? IdspouseOccupation { get; set; }
        public string? IdspouseOccupationOther { get; set; }
        public string? SpousePosition { get; set; }
        public string? SpouseDivisi { get; set; }
        public double? SpouseLengthOfEmployment { get; set; }
        public string? SpouseLineOfBusiness { get; set; }
        public double? SpouseCompanyTotalAsset { get; set; }
        public double? SpouseTotalAsset { get; set; }
        public double? SpouseNetProfit { get; set; }
        public int? SpouseNumberOfEmployees { get; set; }
        public string? IdspouseIncome { get; set; }
        public string? IdspouseIncomeAdditional { get; set; }
        public string? IdspouseSourceAdditionalIncome { get; set; }
        public string? IdspouseSourceAdditionalIncomeOther { get; set; }
        public string? IdspouseSourceOfMainIncome { get; set; }
        public string? IdspouseSourceOfMainIncomeOther { get; set; }
        public double? SpouseTotalIncome { get; set; }
        public string? IdspouseExpenseMonth { get; set; }
        public bool? OtherInfo1YesNo { get; set; }
        public string? OtherInfo11 { get; set; }
        public string? OtherInfo12 { get; set; }
        public bool? OtherInfo2YesNo { get; set; }
        public string? OtherInfo21 { get; set; }
        public string? OtherInfo22 { get; set; }
        public bool? OtherInfo3YesNo { get; set; }
        public string? OtherInfo31 { get; set; }
        public string? OtherInfo32 { get; set; }
        public bool? OtherInfo4YesNo { get; set; }
        public string? OtherInfo41 { get; set; }
        public string? OtherInfo42 { get; set; }
        public bool? OtherInfo5YesNo { get; set; }
        public string? OtherInfo51 { get; set; }
        public string? OtherInfo52 { get; set; }
        public int? IdinvestmentPurposes { get; set; }
        public int? IdinvestmentHorizon { get; set; }
        public bool? ExperienceInvestment1 { get; set; }
        public bool? ExperienceInvestment2 { get; set; }
        public bool? ExperienceInvestment3 { get; set; }
        public bool? ExperienceInvestment4 { get; set; }
        public bool? ExperienceInvestment5 { get; set; }
        public bool? ExperienceInvestment6 { get; set; }
        public bool? ExperienceInvestment7 { get; set; }
        public bool? ExperienceInvestment8 { get; set; }
        public string? ExperienceInvestmentOthersText { get; set; }
        public int? IdcorporateTotalAsset1 { get; set; }
        public int? IdcorporateTotalAsset2 { get; set; }
        public int? IdcorporateTotalAsset3 { get; set; }
        public int? IdcorporateTotalLiabilities1 { get; set; }
        public int? IdcorporateTotalLiabilities2 { get; set; }
        public int? IdcorporateTotalLiabilities3 { get; set; }
        public int? IdcorporateOperatingIncome1 { get; set; }
        public int? IdcorporateOperatingIncome2 { get; set; }
        public int? IdcorporateOperatingIncome3 { get; set; }
        public int? IdcorporateTotalNetProfit1 { get; set; }
        public int? IdcorporateTotalNetProfit2 { get; set; }
        public int? IdcorporateTotalNetProfit3 { get; set; }
        public string? FwPrefix { get; set; }
        public DateTime? FwTimeStamp { get; set; }
        public string? Sid { get; set; }
        public string? FullName { get; set; }
        public string? ExternalCode01 { get; set; }
        public string? ExternalCode02 { get; set; }
        public string? ExternalCode03 { get; set; }
        public string? ExternalCode04 { get; set; }
        public string? ExternalCode05 { get; set; }
        public string? ExternalCode06 { get; set; }
        public string? ExternalCode07 { get; set; }
        public string? ExternalCode08 { get; set; }
        public string? ExternalCode09 { get; set; }
        public string? ExternalCode10 { get; set; }
        public string? SysCreatedBy { get; set; }
        public DateTime? SysCreatedTime { get; set; }
        public string? SysCreatedHost { get; set; }
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }
        public bool? OtherInfo6YesNo { get; set; }
        public string? OtherInfo61 { get; set; }
        public string? OtherInfo62 { get; set; }
        public string? OtherInfo63 { get; set; }
        public bool? OtherInfo7YesNo { get; set; }
        public string? OtherInfo71 { get; set; }
        public string? OtherInfo72 { get; set; }
        public string? OtherInfo73 { get; set; }
        public bool? OtherInfo8YesNo { get; set; }
        public string? OtherInfo81 { get; set; }
        public string? OtherInfo82 { get; set; }
        public string? OtherInfo83 { get; set; }
        public string? OtherInfo84 { get; set; }
        public bool? OtherInfo9YesNo { get; set; }
        public string? OtherInfo91 { get; set; }
        public string? OtherInfo92 { get; set; }
        public string? OtherInfo93 { get; set; }
        public bool? OtherInfo10YesNo { get; set; }
        public string? OtherInfo101 { get; set; }
        public string? OtherInfo102 { get; set; }
        public string? OtherInfo103 { get; set; }
        public bool? OtherInfo11YesNo { get; set; }
        public string? OtherInfo111 { get; set; }
        public string? OtherInfo112 { get; set; }
        public string? OtherInfo113 { get; set; }
        public bool? OtherInfo12YesNo { get; set; }
        public string? OtherInfo121 { get; set; }
        public string? OtherInfo122 { get; set; }
        public string? OtherInfo123 { get; set; }
        public bool? OtherInfo13YesNo { get; set; }
        public bool? OtherInfo14YesNo { get; set; }
        public bool? OtherInfo15YesNo { get; set; }
        public bool? IsAffiliation { get; set; }
        public string? Nik { get; set; }
        public string? Hobby { get; set; }
        public string? IdsourceOfFundsOther { get; set; }
        public string? IdobjectivesOther { get; set; }
        public string? Idrevenue { get; set; }
        public string? IdrevenueOther { get; set; }
        public string? IdspouseRevenue { get; set; }
        public string? IdspouseRevenueOther { get; set; }
        public string? SpouseMiddleName { get; set; }
        public string? SpouseLastName { get; set; }
        public string? IdspouseOccupationLineOfBusiness { get; set; }
        public string? IdpengirimanKonfirmasi { get; set; }
        public string? OtherInfo43 { get; set; }
        public string? OtherInfo53 { get; set; }
        public string? OtherInfo33 { get; set; }
        public DateTime? TdpregDate { get; set; }
        public string? FundUnitAccount { get; set; }
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
        public string? OfficeName { get; set; }
        public string? HobbyOthers { get; set; }
        public string? IdpenghasilanUtama { get; set; }
        public string? IdutamaLainnya { get; set; }
        public string? IdpenghasilanTambahan { get; set; }
        public string? IdtambahanLainnya { get; set; }
        public bool? IsFatca { get; set; }
        public bool? SocialInsurance { get; set; }
        public int? IsEmitenOrPublic { get; set; }
        public string? SubRegNo { get; set; }
        public string? SubRegNoStatus { get; set; }
        public double? BondSellTax { get; set; }
        public string? Bcnumber { get; set; }
        public string? Sidgov { get; set; }
        public string? Sidcorp { get; set; }
        public string? SubRekNo { get; set; }
        public string? Aidno { get; set; }
        public bool? IsCorpBond { get; set; }
        public bool? IsGovBond { get; set; }
        public DateTime? SidgeneratedDate { get; set; }
        public DateTime? SidgovGeneratedDate { get; set; }
        public DateTime? SidcorpGeneratedDate { get; set; }
        public DateTime? OpDateMf { get; set; }
        public DateTime? OpDateGovBond { get; set; }
        public DateTime? OpDateCorpBond { get; set; }
        public bool? IsMf { get; set; }
        public string? InvestorTypeOfSupplementaryDocs { get; set; }
        public DateTime? InvestorExpiredDateOfSupplementaryDocs { get; set; }
        public string? IsIdexpiredSeumurHidup { get; set; }
        public string? TaxCode { get; set; }
    }
}
