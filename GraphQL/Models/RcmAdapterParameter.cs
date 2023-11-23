using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdapterParameter
    {
        public RcmAdapterParameter()
        {
            RcmAdapterMappings = new HashSet<RcmAdapterMapping>();
        }

        public int ParameterId { get; set; }
        public int AdapterTypeId { get; set; }
        public int ParameterMasterId { get; set; }
        public bool AllowDuplicate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual RcmAdapterType AdapterType { get; set; } = null!;
        public virtual RcmAdapterParameterMaster ParameterMaster { get; set; } = null!;
        public virtual ICollection<RcmAdapterMapping> RcmAdapterMappings { get; set; }
    }
}
