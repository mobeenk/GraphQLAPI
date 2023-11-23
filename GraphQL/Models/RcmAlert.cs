﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAlert
    {
        public long AlertId { get; set; }
        public int OrganizationId { get; set; }
        public int FromId { get; set; }
        public string? Message { get; set; }
        public string MessageType { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public bool? IsHtml { get; set; }
        public bool? IsSystemGenerated { get; set; }
        public bool? IsReply { get; set; }
        public int? OriMessageId { get; set; }
        public bool DeleteFlag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
