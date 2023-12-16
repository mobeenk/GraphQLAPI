using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmPayer
    {
        public RcmPayer()
        {
            RcmClaims = new HashSet<RcmClaim>();
            RcmPayerDetails = new HashSet<RcmPayerDetail>();
            RcmPayerPolicies = new HashSet<RcmPayerPolicy>();
            RePayerEventRuleGroups = new HashSet<RePayerEventRuleGroup>();
        }

        public int PayerId { get; set; }
        public int OrganizationId { get; set; }
        public string PayerName { get; set; } = null!;
        public string PayerNameN { get; set; } = null!;
        public string? EmailAddress { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactMobile { get; set; }
        public string? Fax { get; set; }
        public string? PhoneOffice1 { get; set; }
        public string? PhoneOffice2 { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? CompanyUrl { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string? Pobox { get; set; }
        public string? ZipCode { get; set; }
        public string? Address { get; set; }
        public bool? Taxable { get; set; }
        public string? CardFormat { get; set; }
        public string? TaxRegistrationNo { get; set; }
        public short? ClaimType { get; set; }
        public byte? PayerType { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }
        public bool? IsNphiesEnable { get; set; }
        public string? NphiesLicenseNo { get; set; }
        public bool? IsTpa { get; set; }
        public bool? IsManagedByTpa { get; set; }
        public int? ParentPayerId { get; set; }
        public string? PayerCrnumber { get; set; }
        public string? PayerAddressArabic { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressStreetN { get; set; }
        public int? BuildingNumber { get; set; }
        public int? PlotIdentification { get; set; }
        public string? StateName { get; set; }
        public string? StateNameN { get; set; }
        public string? CityName { get; set; }
        public string? CityNameN { get; set; }
        public string? CountryName { get; set; }
        public string? CountryNameN { get; set; }
        public string? CountryCode { get; set; }
        public string? CountrySubIdentity { get; set; }
        public string? CountrySubIdentityN { get; set; }
        public string? IdentificationType { get; set; }
        public string? CitySubdivision { get; set; }
        public string? CitySubdivisionN { get; set; }
        public bool? IsReferral { get; set; }
        public string? PayerAuthorizedPersonNameAr { get; set; }
        public string? PayerAuthorizedPersonNameEn { get; set; }
        public string? PayerAuthorizedPersonDesignationAr { get; set; }
        public string? PayerAuthorizedPersonDesignationEn { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionAr { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public int? OrderSequence { get; set; }

        public virtual RcmOrganization Organization { get; set; } = null!;
        public virtual ICollection<RcmClaim> RcmClaims { get; set; }
        public virtual ICollection<RcmPayerDetail> RcmPayerDetails { get; set; }
        public virtual ICollection<RcmPayerPolicy> RcmPayerPolicies { get; set; }
        public virtual ICollection<RePayerEventRuleGroup> RePayerEventRuleGroups { get; set; }
    }
}
