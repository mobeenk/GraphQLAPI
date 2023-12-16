using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmReconciliationCreditNote
    {
        public long ReconciliationCreditNoteId { get; set; }
        public long ReconciliationSummaryId { get; set; }
        public string? ReferenceNumber { get; set; }
        public short? Type { get; set; }
        public short? EffectedType { get; set; }
        public decimal? OldValue { get; set; }
        public decimal? NewValue { get; set; }
        public decimal? Amount { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual RcmReconciliationSummary ReconciliationSummary { get; set; } = null!;
    }
}
