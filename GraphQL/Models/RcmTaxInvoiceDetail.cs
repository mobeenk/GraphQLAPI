using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTaxInvoiceDetail
    {
        public long TaxInvoiceDetailsId { get; set; }
        public int OrganizationId { get; set; }
        public long TaxInvoiceNo { get; set; }
        public int LineItemNo { get; set; }
        public long ClaimId { get; set; }
        public int PayerPolicyId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] RowVer { get; set; } = null!;

        public virtual RcmTaxInvoiceHeader RcmTaxInvoiceHeader { get; set; } = null!;
    }
}
