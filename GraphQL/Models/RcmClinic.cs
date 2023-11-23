﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmClinic
    {
        public int ClinicId { get; set; }
        public int FacilityId { get; set; }
        public int FacilityGroupId { get; set; }
        public int OrganizationId { get; set; }
        public string ClinicName { get; set; } = null!;
        public string ClinicNameN { get; set; } = null!;
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }
        public bool? IsDental { get; set; }

        public virtual RcmFacility RcmFacility { get; set; } = null!;
    }
}
