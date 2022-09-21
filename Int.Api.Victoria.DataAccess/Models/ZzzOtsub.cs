using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class ZzzOtsub
    {
        public long? NoUrutSub { get; set; }
        public long Idcustomer { get; set; }
        public long Idproduct { get; set; }
        public string Idcategory { get; set; } = null!;
        public double? Navvalue { get; set; }
        public double? Units { get; set; }
        public long? IdsubAccount { get; set; }
        public int Idsales { get; set; }
        public DateTime? Navdate { get; set; }
        public long Idtransaction { get; set; }
        public double Otssub { get; set; }
    }
}
