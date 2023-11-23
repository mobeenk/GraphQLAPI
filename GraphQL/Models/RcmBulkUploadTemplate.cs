using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmBulkUploadTemplate
    {
        public int BulkUploadTemplateId { get; set; }
        public int OrganizationId { get; set; }
        public string TemplateType { get; set; } = null!;
        public int SegmentId { get; set; }
        public string EntityName { get; set; } = null!;
        public string? EntityMapWithHeader { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
