using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdjustmentType
    {
        public RcmAdjustmentType()
        {
            RcmPaymentReconcilations = new HashSet<RcmPaymentReconcilation>();
        }

        public int AdjustmentTypeId { get; set; }
        public bool IsPercentageAdjustable { get; set; }
        public string Name { get; set; } = null!;
        public decimal? AdjustmentPercent { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<RcmPaymentReconcilation> RcmPaymentReconcilations { get; set; }
    }
}
