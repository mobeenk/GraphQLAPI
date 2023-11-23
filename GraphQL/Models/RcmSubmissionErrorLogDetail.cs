using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmSubmissionErrorLogDetail
    {
        public long ErrorLogId { get; set; }
        public string ErrorType { get; set; } = null!;
        public long ClaimId { get; set; }
        public byte? PayerType { get; set; }
        public string? RequestDetails { get; set; }
        public string? ResponseDetails { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }
        public string? ExternalRefrenceId { get; set; }
        public bool? Isactive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
