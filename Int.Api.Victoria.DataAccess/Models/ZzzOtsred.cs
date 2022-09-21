using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class ZzzOtsred
    {
        public long? NoUrutRed { get; set; }
        public long Idtransaction { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public long? IdsubAccount { get; set; }
        public string Idcategory { get; set; } = null!;
        public DateTime? Navdate { get; set; }
        public double? Navvalue { get; set; }
        public double? Units { get; set; }
        public double Otsred { get; set; }
    }
}
