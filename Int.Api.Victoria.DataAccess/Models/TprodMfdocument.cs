using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TprodMfdocument
    {
        public int MfdocumentsId { get; set; }
        public int? ProductId { get; set; }
        public string? DocTitle { get; set; }
        public string? DocLocation { get; set; }
        public DateTime? DocDate { get; set; }
        public string? Contents { get; set; }
    }
}
