using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RePayerEventRuleGroup
    {
        public int PayerEventsRuleGroupId { get; set; }
        public int PayerId { get; set; }
        public int OrganizationId { get; set; }
        public int EventId { get; set; }
        public int RuleGroupId { get; set; }
        public string? EntityName { get; set; }
        public bool? IsActive { get; set; }

        public virtual RcmPayer RcmPayer { get; set; } = null!;
        public virtual ReRuleGroup RuleGroup { get; set; } = null!;
    }
}
