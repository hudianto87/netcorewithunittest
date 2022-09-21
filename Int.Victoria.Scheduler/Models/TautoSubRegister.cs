using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TautoSubRegister
    {
        public TautoSubRegister()
        {
            TautoSubRegisterGenerates = new HashSet<TautoSubRegisterGenerate>();
            TautoSubRegisterLogDetails = new HashSet<TautoSubRegisterLogDetail>();
        }

        public long TautoSubRegisterId { get; set; }
        public long? Idcustomer { get; set; }
        public long? Idproduct { get; set; }
        public long? IdsubAccount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DebitDate { get; set; }
        public string FeeType { get; set; } = null!;
        public double FeePercentage { get; set; }
        public double Amount { get; set; }
        public double FeeAmount { get; set; }
        public double NetAmount { get; set; }
        public int IdcustBankAccount { get; set; }
        public int IdproductBankAccount { get; set; }
        public string Idstatus { get; set; } = null!;
        public string? Remarks { get; set; }
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual TcustBankAccount IdcustBankAccountNavigation { get; set; } = null!;
        public virtual Tcustomer? IdcustomerNavigation { get; set; }
        public virtual TproductBankAccount IdproductBankAccountNavigation { get; set; } = null!;
        public virtual Tproduct? IdproductNavigation { get; set; }
        public virtual TsubAccount? IdsubAccountNavigation { get; set; }
        public virtual ICollection<TautoSubRegisterGenerate> TautoSubRegisterGenerates { get; set; }
        public virtual ICollection<TautoSubRegisterLogDetail> TautoSubRegisterLogDetails { get; set; }
    }
}
