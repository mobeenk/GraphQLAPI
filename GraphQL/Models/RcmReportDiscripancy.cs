using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmReportDiscripancy
    {
        public int ReportId { get; set; }
        public string DiscripancyType { get; set; } = null!;
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal? CyclusGrossAmount { get; set; }
        public decimal? VidaGrossAmount { get; set; }
        public decimal? CyclusCompanyShare { get; set; }
        public decimal? VidaCompanyShare { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreateBy { get; set; }
        public int? FacilityId { get; set; }
        public string? VidaCompanyName { get; set; }
        public string? RcmCompanyName { get; set; }
        public int? GroupId { get; set; }
        public int? CompanyId { get; set; }
        public decimal? ClaimAmount { get; set; }
    }
}
