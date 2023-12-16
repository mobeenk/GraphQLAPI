using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmFacility
    {
        public RcmFacility()
        {
            RcmClinics = new HashSet<RcmClinic>();
        }

        public int FacilityId { get; set; }
        public int OrganizationId { get; set; }
        public int FacilityGroupId { get; set; }
        public string FacilityName { get; set; } = null!;
        public string FacilityNameN { get; set; } = null!;
        public string? EmailAddress { get; set; }
        public string? WebSiteUrl { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string? AddressArea { get; set; }
        public string? AddressStreet { get; set; }
        public string? ZipCode { get; set; }
        public string PhoneOffice1 { get; set; } = null!;
        public string? PhoneOffice2 { get; set; }
        public string? FaxNo { get; set; }
        public string? RegistrationNo { get; set; }
        public string? TaxRegistrationNo { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ExternalCode { get; set; }
        public string? ClientName { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte? DataUploadingType { get; set; }
        public byte? CutOfDays { get; set; }
        public byte? CutOfDate { get; set; }
        public string? ExternalCode2 { get; set; }
        public bool? IsNphiesEnable { get; set; }
        public string? NphiesLicenseNo { get; set; }
        public string? FacilityNameAlias { get; set; }
        public string? FacilityCrnumber { get; set; }
        public string? FacilityAddress { get; set; }
        public string? FacilityAddressArabic { get; set; }
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
        public string? FacilityLogo { get; set; }
        public string? FacilityAuthorizedPersonNameAr { get; set; }
        public string? FacilityAuthorizedPersonNameEn { get; set; }
        public string? FacilityAuthorizedPersonDesignationAr { get; set; }
        public string? FacilityAuthorizedPersonDesignationEn { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionAr { get; set; }
        public DateTime? RegisteredOn { get; set; }
        
        public virtual RcmFacilityGroup RcmFacilityGroup { get; set; } = null!;
        public virtual ICollection<RcmClinic> RcmClinics { get; set; }
    }
}
