using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmMappingType
    {
        public RcmMappingType()
        {
            RcmTransactionMappings = new HashSet<RcmTransactionMapping>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; } = null!;

        public virtual ICollection<RcmTransactionMapping> RcmTransactionMappings { get; set; }
    }
}
