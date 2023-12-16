using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class ReResultSeverityLevel
    {
        public ReResultSeverityLevel()
        {
            ReRuleResults = new HashSet<ReRuleResult>();
        }

        public int SeverityId { get; set; }
        public string SeverityName { get; set; } = null!;
        public bool? IsActive { get; set; }

        public virtual ICollection<ReRuleResult> ReRuleResults { get; set; }
    }
}
