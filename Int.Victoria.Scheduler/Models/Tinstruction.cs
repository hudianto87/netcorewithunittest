using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class Tinstruction
    {
        public string? InstructionId { get; set; }
        public string? InstructionReport { get; set; }
        public string? Upname1 { get; set; }
        public string? Upname2 { get; set; }
        public string? Upname3 { get; set; }
        public string? AddressAgent { get; set; }
        public string? PhoneAgent { get; set; }
        public string? FaxAgent { get; set; }
        public string? ZipAgent { get; set; }
        public string? CityAgent { get; set; }
        public string? AddressUp { get; set; }
        public string? PhoneUp { get; set; }
        public string? FaxUp { get; set; }
        public string? ZipUp { get; set; }
        public string? CityUp { get; set; }
    }
}
