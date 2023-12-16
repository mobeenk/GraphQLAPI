using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTaskAssignment
    {
        public int Id { get; set; }
        public int? TaskDetailId { get; set; }
        public int? UserId { get; set; }
        public long ClaimId { get; set; }
        public int OrganizationId { get; set; }
        public byte? Status { get; set; }
        public bool? TechnicalError { get; set; }
        public bool? MedicalError { get; set; }
        public int? CompletedBy { get; set; }
        public DateTime? CompletedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AssignedOn { get; set; }
        public int? OrganizationRoleId { get; set; }

        public virtual RcmClaim RcmClaim { get; set; } = null!;
    }
}
