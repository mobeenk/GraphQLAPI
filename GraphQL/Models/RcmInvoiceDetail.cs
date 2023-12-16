using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmInvoiceDetail
    {
        public long InvoiceDetailId { get; set; }
        public long EinvoiceNo { get; set; }
        public int Quantity { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PatientShare { get; set; }
        public decimal CompanyShare { get; set; }
        public decimal CompanyTax { get; set; }
        public decimal PatientTax { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
