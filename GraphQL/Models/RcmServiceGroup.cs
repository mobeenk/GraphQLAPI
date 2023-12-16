using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmServiceGroup
    {
        public RcmServiceGroup()
        {
            RcmServiceCatalogs = new HashSet<RcmServiceCatalog>();
        }

        public int ServiceGroupId { get; set; }
        public int FacilityGroupId { get; set; }
        public int OrganizationId { get; set; }
        public string ServiceGroupName { get; set; } = null!;
        public string ServiceGroupNameN { get; set; } = null!;
        public string? ServiceGroupCode { get; set; }
        public string Alias { get; set; } = null!;
        public string AliasN { get; set; } = null!;
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }

        public virtual RcmFacilityGroup RcmFacilityGroup { get; set; } = null!;
        public virtual ICollection<RcmServiceCatalog> RcmServiceCatalogs { get; set; }
    }
}
