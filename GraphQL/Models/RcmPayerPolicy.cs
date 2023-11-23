using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPayerPolicy
    {
        public int PayerPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public int PayerId { get; set; }
        public string PayerPolicyName { get; set; } = null!;
        public string PayerPolicyNameN { get; set; } = null!;
        public string PayerPolicyNo { get; set; } = null!;
        public DateTime PayerPolicyExpiryDate { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }
        public bool? IsNphiesEnable { get; set; }
        public string? InsuranceNhic { get; set; }
        public int? PayerIdTpa { get; set; }

        public virtual RcmPayer RcmPayer { get; set; } = null!;
    }
}
