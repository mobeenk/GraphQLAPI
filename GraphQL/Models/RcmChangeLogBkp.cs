﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmChangeLogBkp
    {
        public long LogId { get; set; }
        public int ChangeLogId { get; set; }
        public int OrganizationId { get; set; }
        public string EntityName { get; set; } = null!;
        public long TransactionId { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public long? SessionId { get; set; }
    }
}
