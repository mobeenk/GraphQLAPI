using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmReconciliationSummary
    {
        public RcmReconciliationSummary()
        {
            RcmReconciliationCreditNotes = new HashSet<RcmReconciliationCreditNote>();
            RcmReconciliationOverrides = new HashSet<RcmReconciliationOverride>();
        }

        public long ReconciliationSummaryId { get; set; }
        public long ReconciliationId { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public long? EinvoiceNo { get; set; }
        public decimal? ZatcaAmount { get; set; }
        public bool IsActive { get; set; }
        public decimal? OriginalAmountSubmitted { get; set; }
        public decimal? OriginalVatsubmitted { get; set; }
        public decimal? OriginalAmountApproved { get; set; }
        public decimal? OriginalVatapproved { get; set; }
        public decimal? OriginalAmountRejected { get; set; }
        public decimal? OriginalVatrejected { get; set; }
        public decimal? OriginalAmountCollected { get; set; }
        public decimal? OriginalVatcollected { get; set; }
        public decimal? OriginalAmountUnapplied { get; set; }
        public decimal? OriginalVatunapplied { get; set; }
        public decimal? OriginalBalanceAmount { get; set; }
        public decimal? AmountSubmitted { get; set; }
        public decimal? Vatsubmitted { get; set; }
        public decimal? AmountApproved { get; set; }
        public decimal? Vatapproved { get; set; }
        public decimal? AmountRejected { get; set; }
        public decimal? Vatrejected { get; set; }
        public decimal? AmountCollected { get; set; }
        public decimal? Vatcollected { get; set; }
        public decimal? AmountUnapplied { get; set; }
        public decimal? Vatunapplied { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? BalanceAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual RcmReconciliation Reconciliation { get; set; } = null!;
        public virtual ICollection<RcmReconciliationCreditNote> RcmReconciliationCreditNotes { get; set; }
        public virtual ICollection<RcmReconciliationOverride> RcmReconciliationOverrides { get; set; }
    }
}
