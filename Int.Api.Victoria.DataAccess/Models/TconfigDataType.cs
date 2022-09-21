using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TconfigDataType
    {
        public TconfigDataType()
        {
            Tconfigs = new HashSet<Tconfig>();
        }

        public byte TconfigDataTypeId { get; set; }
        public string DataTypeName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Tconfig> Tconfigs { get; set; }
    }
}
