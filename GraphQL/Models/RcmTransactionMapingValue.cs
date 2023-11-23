using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTransactionMapingValue
    {
        public int TransactionMapingValuesId { get; set; }
        public int TransactionType { get; set; }
        public int OrganizationId { get; set; }
        public int TransactionValue { get; set; }
        public int MappingType { get; set; }
        public string MappingValue { get; set; } = null!;
        public int? EncounterType { get; set; }
        public bool? IsDefault { get; set; }
        public string? ExternalCode { get; set; }
        public short? ServiceType { get; set; }
    }
}
