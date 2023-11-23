using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class ReRuleFieldParameterGroup
    {
        public long RuleFieldParamGroupId { get; set; }
        public int RuleFieldId { get; set; }
        public int RuleGroupId { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ReRuleFieldParameter RuleField { get; set; } = null!;
        public virtual ReRuleGroup RuleGroup { get; set; } = null!;
    }
}
