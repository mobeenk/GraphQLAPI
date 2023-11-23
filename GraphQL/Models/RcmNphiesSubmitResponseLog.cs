using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmNphiesSubmitResponseLog
    {
        public long LogId { get; set; }
        public int FacilityId { get; set; }
        public int PayerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Summary { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
