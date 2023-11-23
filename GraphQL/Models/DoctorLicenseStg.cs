using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class DoctorLicenseStg
    {
        public double? DoctorId { get; set; }
        public string? DoctorName { get; set; }
        public string? DoctorIdentificationNo { get; set; }
        public string? ScfshLicense { get; set; }
        public string? LicenseExpiry { get; set; }
        public string? SpecialityIdentifier { get; set; }
        public double? IsUpdated { get; set; }
        public string? SpecialityName { get; set; }
        public string? ErrorLog { get; set; }
        public string? OldLicense { get; set; }
    }
}
