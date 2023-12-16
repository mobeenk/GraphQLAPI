using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmServiceCharge
    {
        public int ServiceChargesId { get; set; }
        public int DimensionId { get; set; }
        public long ServiceId { get; set; }
        public int OrganizationId { get; set; }
        public string? DimReference { get; set; }
        public decimal? Price { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual RcmReferenceDimension Dimension { get; set; } = null!;
        public virtual RcmServiceCatalog Service { get; set; } = null!;
    }
}
