using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmNphiesclaimRejectionAttachmentsReference
    {
        public long Id { get; set; }
        public long AttachmentId { get; set; }
        public string ClaimIdentifier { get; set; } = null!;
        public long ClaimNo { get; set; }
        public int NphiesSeqNo { get; set; }
        public string? ServiceReferenceNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public long? RcmNphiesclaimRejectionRemarksId { get; set; }

        public virtual RcmAttachment Attachment { get; set; } = null!;
        public virtual RcmNphiesclaimRejectionRemark? RcmNphiesclaimRejectionRemarks { get; set; }
    }
}
