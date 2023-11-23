using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPaymentReconcilationDetail
    {
        public long PaymentReconcilationDetailId { get; set; }
        public long PaymentReconcilationId { get; set; }
        public long ClaimId { get; set; }
        public int OrganizationId { get; set; }
        public decimal ClaimAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public decimal SettleAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual RcmPaymentReconcilation PaymentReconcilation { get; set; } = null!;
        public virtual RcmClaim RcmClaim { get; set; } = null!;
    }
}
