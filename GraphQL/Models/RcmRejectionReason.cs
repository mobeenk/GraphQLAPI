using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmRejectionReason
    {
        public int RejectionId { get; set; }
        public string RejectionReason { get; set; } = null!;
        public bool? IsActive { get; set; }
        public int? OrganizationId { get; set; }
        public byte? RejectionType { get; set; }
    }
}
