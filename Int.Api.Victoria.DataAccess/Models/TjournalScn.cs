using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TjournalScn
    {
        public int Rowid { get; set; }
        public string? TransId { get; set; }
        /// <summary>
        /// COA
        /// </summary>
        public string? AccntCode { get; set; }
        public string? AccntDesc { get; set; }
        /// <summary>
        /// D/C
        /// </summary>
        public string? AccntType { get; set; }
        public string? AnalT2 { get; set; }
        public string? AnalT3 { get; set; }
        public string? AnalT4 { get; set; }
        public string? AnalT5 { get; set; }
        public string? AnalA4 { get; set; }
    }
}
