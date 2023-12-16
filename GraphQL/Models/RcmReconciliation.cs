using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmReconciliation
    {
        public RcmReconciliation()
        {
            RcmReconciliationSummaries = new HashSet<RcmReconciliationSummary>();
        }

        public long ReconciliationId { get; set; }
        public int PayerId { get; set; }
        public int FacilityId { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public byte Status { get; set; }
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
        public decimal? BalanceAmount { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public decimal? FinalPayableBalance { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? ZeroRatedAmount { get; set; }
        public decimal? VatpercentAmount { get; set; }
        public DateTime? PayerSigningDate { get; set; }
        public DateTime? FacilitySigningDate { get; set; }
        public DateTime? AgreementDate { get; set; }
        public string? AgreementCity { get; set; }
        public string? FacilityAuthorizedPersonName { get; set; }
        public string? FacilityAuthorizedPersonDesignation { get; set; }
        public string? FacilityDescription { get; set; }
        public DateTime? FacilityCrOn { get; set; }
        public string? PayerAuthorizedPersonName { get; set; }
        public string? PayerAuthorizedPersonDesignation { get; set; }
        public string? PayerDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int? DeActivatedBy { get; set; }
        public DateTime? DeActivatedOn { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? RejectedBy { get; set; }
        public DateTime? RejectedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Uuid { get; set; } = null!;

        public virtual ICollection<RcmReconciliationSummary> RcmReconciliationSummaries { get; set; }
    }
}
