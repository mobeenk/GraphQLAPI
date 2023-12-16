using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmDiagnosis
    {
        public int DiagnosisId { get; set; }
        public string DiagnosisCode { get; set; } = null!;
        public string DiagnosisDescription { get; set; } = null!;
    }
}
