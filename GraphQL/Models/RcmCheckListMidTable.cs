using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmCheckListMidTable
    {
        public long CheckListId { get; set; }
        public int OrganizationId { get; set; }
        public int? FacilityId { get; set; }
        public int CompanyId { get; set; }
        public int SubCategoryId { get; set; }
        public byte CheckListType { get; set; }
        public string CheckList { get; set; } = null!;
        public string? CheckListN { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }
        public bool? IsProccessed { get; set; }
        public DateTime? ReceivedOn { get; set; }
    }
}
