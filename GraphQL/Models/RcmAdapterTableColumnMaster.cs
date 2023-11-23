using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmAdapterTableColumnMaster
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public bool? HasChild { get; set; }
        public string? ColumnDescription { get; set; }
    }
}
