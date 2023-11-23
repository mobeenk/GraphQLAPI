using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class ReEventMaster
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = null!;
        public bool? IsActive { get; set; }
    }
}
