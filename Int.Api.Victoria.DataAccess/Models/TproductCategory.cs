﻿using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TproductCategory
    {
        public long TproductCategoryId { get; set; }
        public string? ProductCategoryName { get; set; }
        public string? ProductCategoryCode { get; set; }
        public string? Remarks { get; set; }
    }
}
