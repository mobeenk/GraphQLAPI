using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdapterParameterMaster
    {
        public RcmAdapterParameterMaster()
        {
            RcmAdapterParameters = new HashSet<RcmAdapterParameter>();
        }

        public int ParameterMasterId { get; set; }
        public string ParameterName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RcmAdapterParameter> RcmAdapterParameters { get; set; }
    }
}
