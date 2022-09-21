using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TfileList
    {
        public int IdList { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public int IsDownload { get; set; }
        public DateTime TrxDate { get; set; }
    }
}
