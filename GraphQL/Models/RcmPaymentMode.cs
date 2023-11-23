using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPaymentMode
    {
        public RcmPaymentMode()
        {
            RcmPaymentReconcilations = new HashSet<RcmPaymentReconcilation>();
        }

        public int PaymentModeId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<RcmPaymentReconcilation> RcmPaymentReconcilations { get; set; }
    }
}
