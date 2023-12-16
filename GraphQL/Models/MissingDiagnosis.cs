using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class MissingDiagnosis
    {
        public long Id { get; set; }
        public string ClaimId { get; set; } = null!;
        public string ClaimIdentifier { get; set; } = null!;
        public string ClaimBundleId { get; set; } = null!;
        public string? ProviderLicenseId { get; set; }
        public string? DiagnosisCode { get; set; }
        public string? PayerClaimId { get; set; }
        public int? FacilityId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
