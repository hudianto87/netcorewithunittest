using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TautoSubRegisterGenerate
    {
        public long TautoSubRegisterGenerateId { get; set; }
        public long TautoSubRegisterId { get; set; }
        public DateTime TrensactionDate { get; set; }
        public DateTime LogDate { get; set; }

        public virtual TautoSubRegister TautoSubRegister { get; set; } = null!;
    }
}
