namespace Int.Api.Victoria.BusinessLayer.BindingModelResult
{
    public class BMRProductCatalog
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int RiskProfileProductID { get; set; }
        public string RiskProfileProductName { get; set; }
        public string FundHouseCode { get; set; }
        public string FundHouseName { get; set; }
        public string Currency { get; set; }
        public double NAV { get; set; }
        public DateTime? NAVDate { get; set; }
        public double Tax { get; set; }
        public string Category { get; set; }
        public double MinSub { get; set; }
        public double MinRed { get; set; }
        public double MinSwt { get; set; }
        public double SubsFee { get; set; }
        public double SubsFeeCrisp { get; set; }
        public double SubsFeeCrispPlus { get; set; }
        public double RedFee { get; set; }
        public double SwtFee { get; set; }
        public int EligibleForCrisp { get; set; }
        public int EligibleForCrispPlus { get; set; }
        public double OneYear { get; set; }
        public double OneMonth { get; set; }
        public string MFType { get; set; }
        public DateTime? PeriodeImbalHasil { get; set; }
        public DateTime? MasaPenawaranStart { get; set; }
        public DateTime? MasaPenawaranEnd { get; set; }
        public DateTime? ExitWindowStart { get; set; }
        public DateTime? ExitWindowEnd { get; set; }
        public double InitialNAV { get; set; }
        public bool IsActive { get; set; }

        public double SubsFeeEmployee { get; set; }
        public double RedFeeEmployee { get; set; }
        public double SwtFeeEmployee { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string CutOffTime { get; set; }
    }
}
