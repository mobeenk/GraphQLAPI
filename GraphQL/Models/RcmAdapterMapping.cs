using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdapterMapping
    {
        public int AdapterMappingId { get; set; }
        public int AdapterId { get; set; }
        public int ParameterMasterId { get; set; }
        public string ParameterType { get; set; } = null!;
        public string ParameterValue { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual RcmAdapter Adapter { get; set; } = null!;
        public virtual RcmAdapterParameter ParameterMaster { get; set; } = null!;
    }
}
