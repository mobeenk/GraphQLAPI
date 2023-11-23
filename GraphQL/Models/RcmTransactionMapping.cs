using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTransactionMapping
    {
        public int MappingTypeId { get; set; }
        public int TransactionTypeId { get; set; }

        public virtual RcmMappingType MappingType { get; set; } = null!;
    }
}
