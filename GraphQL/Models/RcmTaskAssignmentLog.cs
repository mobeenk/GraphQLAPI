using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTaskAssignmentLog
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public byte Status { get; set; }
        public string Description { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
