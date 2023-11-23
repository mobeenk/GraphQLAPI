using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmExternalServiceConfiguration
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int FacilityId { get; set; }
        public int PayerId { get; set; }
        public string ConfigKey { get; set; } = null!;
        public string ConfigValue { get; set; } = null!;
        public bool? IsActive { get; set; }
    }
}
