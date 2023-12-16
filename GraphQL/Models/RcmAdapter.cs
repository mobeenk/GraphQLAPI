﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdapter
    {
        public RcmAdapter()
        {
            RcmAdapterColumnMappingMasters = new HashSet<RcmAdapterColumnMappingMaster>();
            RcmAdapterMappings = new HashSet<RcmAdapterMapping>();
        }

        public int AdapterId { get; set; }
        public int OrganizationId { get; set; }
        public int AdapterTypeId { get; set; }
        public string AdapterName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? FileType { get; set; }
        public string? AdaptorCode { get; set; }

        public virtual RcmAdapterType AdapterType { get; set; } = null!;
        public virtual ICollection<RcmAdapterColumnMappingMaster> RcmAdapterColumnMappingMasters { get; set; }
        public virtual ICollection<RcmAdapterMapping> RcmAdapterMappings { get; set; }
    }
}
