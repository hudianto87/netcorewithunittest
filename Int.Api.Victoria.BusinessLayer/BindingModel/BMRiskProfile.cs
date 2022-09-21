using System.ComponentModel.DataAnnotations;
namespace Int.Api.Victoria.BusinessLayer.BindingModel
{
    public class BMRiskProfile
    {
        [Required][MaxLength(10)] public string ChannelID { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string CIF { get; set; } = string.Empty;
        [Required][MaxLength(100)] public string NamaDepan { get; set; } = string.Empty;
        [MaxLength(20)] public string NamaTengah { get; set; } = string.Empty;
        [MaxLength(20)] public string NamaBelakang { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string JenisIdentitas { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string Kewarganegaraan { get; set; } = string.Empty;
        [Required][MaxLength(16)] public string NomorIdentitas { get; set; } = string.Empty;
        [Required] public DateTime MasaBerlakuID { get; set; }
        [MaxLength(20)] public string NPWP { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string TempatLahir { get; set; } = string.Empty;
        [Required] public DateTime TanggalLahir { get; set; }
        [Required][MaxLength(20)] public string JenisKelamin { get; set; } = string.Empty;
        [Required][MaxLength(10)] public string StatusPerkawinan { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string Pendidikan { get; set; } = string.Empty;
        [Required][MaxLength(8)] public string Agama { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string Penghasilan { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string SumberDana { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string MaksudTujuan { get; set; } = string.Empty;
        public List<CustBankAccount> bankAccounts { get; set; } = new List<CustBankAccount>();
        [Required][MaxLength(50)] public string Email { get; set; } = string.Empty;
        [Required][MaxLength(15)] public string NoTelepon { get; set; } = string.Empty;
        [Required][MaxLength(15)] public string NoHP { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string KotaKTP { get; set; } = string.Empty;
        [Required][MaxLength(5)] public string KodePosKTP { get; set; } = string.Empty;
        [Required][MaxLength(150)] public string AlamatKTP { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string ProvinsiKTP { get; set; } = string.Empty;
        [MaxLength(50)] public string NegaraKTP { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string KotaTinggal { get; set; } = string.Empty;
        [Required][MaxLength(5)] public string KodePosTinggal { get; set; } = string.Empty;
        [Required][MaxLength(150)] public string AlamatTinggal { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string ProvinsiTinggal { get; set; } = string.Empty;
        [MaxLength(50)] public string NegaraTinggal { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string Pekerjaan { get; set; } = string.Empty;
        [MaxLength(100)] public string NamaIbuKandung { get; set; } = string.Empty;
        [MaxLength(100)] public string NamaAhliwaris { get; set; } = string.Empty;
        [MaxLength(50)] public string HubunganAhliwaris { get; set; } = string.Empty;
        [MaxLength(100)] public string NamaPasangan { get; set; } = string.Empty;
        public List<Questionnaire> ListQuestionnaire { get; set; } = new();
        [MaxLength(2)] public string ActionType { get; set; } = string.Empty;
        [MaxLength(2)] public string SIDRequested { get; set; } = string.Empty;
    }
    public class CustBankAccount
    {
        [Required][MaxLength(20)] public string BankCode { get; set; } = string.Empty;
        [Required] public int IDCabang { get; set; }
        [Required][MaxLength(50)] public string NamaCabang { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string NoRekening { get; set; } = string.Empty;
        [Required][MaxLength(50)] public string NamaRekening { get; set; } = string.Empty;
        [Required][MaxLength(20)] public string MataUang { get; set; } = string.Empty;
    }
    public class Questionnaire
    {
        [Required] public int QuestionNo { get; set; }
        [MaxLength(2)] public string Answer { get; set; } = string.Empty;
        [MaxLength(20)] public string Type { get; set; } = string.Empty;
    }
}
