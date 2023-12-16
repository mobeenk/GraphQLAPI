using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class ReRuleUserFunction
    {
        public int FunctionId { get; set; }
        public string FunctionName { get; set; } = null!;
        public int ParameterCount { get; set; }
        public string? ParameterNameSepByComma { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
