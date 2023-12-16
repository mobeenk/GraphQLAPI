using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmEncounterMedicalDetail
    {
        public long MedicalInfoId { get; set; }
        public int OrganizationId { get; set; }
        public string FacilityGroupId { get; set; } = null!;
        public int FacilityId { get; set; }
        public string EncounterNo { get; set; } = null!;
        public string PatientMrn { get; set; } = null!;
        public string? MedicalData { get; set; }
        public bool IsActive { get; set; }
        public int Createdby { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
