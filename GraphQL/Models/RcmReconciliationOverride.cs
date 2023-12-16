using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmReconciliationOverride
    {
        public long ReconciliationOverrideId { get; set; }
        public long ReconciliationSummaryId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Net { get; set; }
        public string? Remarks { get; set; }
        public short? Type { get; set; }
        public short? EffectedType { get; set; }
        public decimal? OldValue { get; set; }
        public decimal? NewValue { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual RcmReconciliationSummary ReconciliationSummary { get; set; } = null!;
    }
}
