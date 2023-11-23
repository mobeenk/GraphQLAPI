using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmClaimNphiesPostTrail
    {
        public long Id { get; set; }
        public long ClaimId { get; set; }
        public string ClaimIdentifier { get; set; } = null!;
        public string ClaimBundleId { get; set; } = null!;
        public string? PreviousClaimIdentifier { get; set; }
        public string? PrevoiusClaimBundleId { get; set; }
        public int? OrganizationId { get; set; }
        public int SequenceNumber { get; set; }
        public long? ProcessId { get; set; }
        public int? CriteriaType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
