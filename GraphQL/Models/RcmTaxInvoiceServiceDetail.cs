using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmTaxInvoiceServiceDetail
    {
        public long TaxInvoiceServiceDetailsId { get; set; }
        public long TaxInvoiceNo { get; set; }
        public int OrganizationId { get; set; }
        public int LineItemNo { get; set; }
        public byte InvoiceType { get; set; }
        public string ServiceCode { get; set; } = null!;
        public string? ServiceName { get; set; }
        public string? ServiceNameN { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AmountExclusiveVat { get; set; }
        public decimal TaxPct { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal AmountInclusiveVat { get; set; }
        public decimal Price { get; set; }
        public decimal PatientShare { get; set; }
        public decimal CompanyShare { get; set; }
        public byte? TaxType { get; set; }
        public decimal PatientTaxAmount { get; set; }
        public decimal CompanyTaxAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public byte[] RowVer { get; set; } = null!;

        public virtual RcmTaxInvoiceHeader RcmTaxInvoiceHeader { get; set; } = null!;
    }
}
