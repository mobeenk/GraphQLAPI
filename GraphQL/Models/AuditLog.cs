using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class AuditLog
    {
        public long Id { get; set; }
        public string? TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string? KeyValues { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public int Createdby { get; set; }
        public long? ClaimId { get; set; }
        public int? OrganizationId { get; set; }
        public long? ServiceId { get; set; }
        public long? RowId { get; set; }
        public int? NphiesSeqNo { get; set; }
        public string? ReasonCode { get; set; }
        public string? ItemReason { get; set; }
    }
}
