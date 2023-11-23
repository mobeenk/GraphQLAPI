﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmBulkuploadErrorLog
    {
        public long BulkuploadErrorId { get; set; }
        public string BulkuploadProcessLogId { get; set; } = null!;
        public string SourceType { get; set; } = null!;
        public long SourceReferenceId { get; set; }
        public byte[]? ErrorMessage { get; set; }
        public int? ErrorId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
