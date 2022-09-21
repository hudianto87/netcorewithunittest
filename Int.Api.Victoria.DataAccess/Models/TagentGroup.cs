using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TagentGroup
    {
        public TagentGroup()
        {
            TagentGroupLists = new HashSet<TagentGroupList>();
        }

        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<TagentGroupList> TagentGroupLists { get; set; }
    }
}
