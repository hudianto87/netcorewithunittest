using System;
using System.Collections.Generic;

namespace Int.Api.Victoria.DataAccess.Models
{
    public partial class TuploadFile
    {
        public long FileId { get; set; }
        public string FileName { get; set; } = null!;
        public string FileExtention { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public string UploadBy { get; set; } = null!;
        public string FileUsedFor { get; set; } = null!;
        public long? Idproduct { get; set; }
        public DateTime? FileDate { get; set; }
    }
}
