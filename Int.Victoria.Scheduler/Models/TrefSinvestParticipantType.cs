using System;
using System.Collections.Generic;

namespace Int.Victoria.Scheduler.Models
{
    public partial class TrefSinvestParticipantType
    {
        public TrefSinvestParticipantType()
        {
            Tcompanies = new HashSet<Tcompany>();
        }

        public long TrefSinvestParticipantTypeId { get; set; }
        public string ParticipantType { get; set; } = null!;
        public string TypeName { get; set; } = null!;
        public string SysCreatedBy { get; set; } = null!;
        public DateTime SysCreatedTime { get; set; }
        public string SysCreatedHost { get; set; } = null!;
        public string? SysModifiedBy { get; set; }
        public DateTime? SysModifiedTime { get; set; }
        public string? SysModifiedHost { get; set; }

        public virtual ICollection<Tcompany> Tcompanies { get; set; }
    }
}
