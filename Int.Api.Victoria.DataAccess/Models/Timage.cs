using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class Timage
    {
        public int ImageId { get; set; }
        public byte[]? Image { get; set; }
    }
}
