using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPaymentReconcilation
    {
        public RcmPaymentReconcilation()
        {
            RcmPaymentReconcilationDetails = new HashSet<RcmPaymentReconcilationDetail>();
        }

        public long PaymentReconcilationId { get; set; }
        public int OrganizationId { get; set; }
        public int FacilityId { get; set; }
        public int PayerId { get; set; }
        public DateTime PeriodFromDate { get; set; }
        public DateTime PeriodToDate { get; set; }
        public DateTime PaymentTransactionDate { get; set; }
        public decimal ReceivedAmount { get; set; }
        public string? PayeeReference { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string? Remarks { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public decimal? TotalClaimAmount { get; set; }
        public decimal? TotalApprovedAmount { get; set; }
        public decimal? TotalSettledAmount { get; set; }
        public decimal? AdjustedClaimAmountPercent { get; set; }
        public bool IsAutomatic { get; set; }
        public int? AdjustmentTypeId { get; set; }
        public int? PaymentModeId { get; set; }
        public decimal? AdjustmentPercentage { get; set; }
        public long? AttachmentId { get; set; }
        public int Status { get; set; }
        public bool? IsReconciled { get; set; }
        public long? ReferrenceId { get; set; }
        public bool? IsTransferWithinFacility { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int? DeActivatedBy { get; set; }
        public DateTime? DeActivatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual RcmAdjustmentType? AdjustmentType { get; set; }
        public virtual RcmOrganization Organization { get; set; } = null!;
        public virtual RcmPaymentMode? PaymentMode { get; set; }
        public virtual ICollection<RcmPaymentReconcilationDetail> RcmPaymentReconcilationDetails { get; set; }
    }
}
