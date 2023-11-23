﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPayerDetail
    {
        public int PayerId { get; set; }
        public int OrganizationId { get; set; }
        public int DimensionId { get; set; }
        public string? DimReference { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }

        public virtual RcmReferenceDimension Dimension { get; set; } = null!;
        public virtual RcmPayer RcmPayer { get; set; } = null!;
    }
}
