using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TrefInstructionCustody
    {
        public int CustodyId { get; set; }
        public string? CustodyName { get; set; }
        public string? CustodyStreet1 { get; set; }
        public string? CustodyStreet2 { get; set; }
        public string? CustodyCity { get; set; }
        public string? CustodyPhone { get; set; }
        public string? CustodyFax { get; set; }
        public string? CustodyZip { get; set; }
        public string? ContactPerson { get; set; }
    }
}
