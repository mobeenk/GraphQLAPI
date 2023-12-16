using GraphQL.DTOs;
using GraphQL.Models;
using GraphQL.Repositories;

namespace GraphQL.MutationTypes
{
    public class FacilityMutations
    {
        public async Task<bool> AddFacilityAsync([Service] IFacilityRepository repo, RcmFacilityDTO details)
        {
            var sanitizedDetails = new RcmFacility
            {
                // Copy only the fields you want to include
             //   FacilityId = details.FacilityId,
                OrganizationId = details.OrganizationId,
                FacilityGroupId = details.FacilityGroupId,
                FacilityName = details.FacilityName,
                FacilityNameN = details.FacilityNameN,
                EmailAddress = details.EmailAddress,
                WebSiteUrl = details.WebSiteUrl,
                CountryId = details.CountryId,
                StateId = details.StateId,
                CityId = details.CityId,
                AddressArea = details.AddressArea,
                AddressStreet = details.AddressStreet,
                ZipCode = details.ZipCode,
                PhoneOffice1 = details.PhoneOffice1,
                PhoneOffice2 = details.PhoneOffice2,
                FaxNo = details.FaxNo,
                RegistrationNo = details.RegistrationNo,
                TaxRegistrationNo = details.TaxRegistrationNo,
                IsActive = details.IsActive,
                CreatedBy = details.CreatedBy,
                CreatedOn = details.CreatedOn
            };

            return await repo.AddFacilityAsync(sanitizedDetails);
        }

        public async Task<bool> UpdateFacilityAsync([Service] IFacilityRepository repo, RcmFacilityDTO details)
        {
            var sanitizedDetails = new RcmFacility
            {
         
                FacilityId = details.FacilityId,  //PK
                OrganizationId = details.OrganizationId,
                FacilityGroupId = details.FacilityGroupId,
                FacilityName = details.FacilityName,
                FacilityNameN = details.FacilityNameN,
                EmailAddress = details.EmailAddress,
                WebSiteUrl = details.WebSiteUrl,
                CountryId = details.CountryId,
                StateId = details.StateId,
                CityId = details.CityId,
                AddressArea = details.AddressArea,
                AddressStreet = details.AddressStreet,
                ZipCode = details.ZipCode,
                PhoneOffice1 = details.PhoneOffice1,
                PhoneOffice2 = details.PhoneOffice2,
                FaxNo = details.FaxNo,
                RegistrationNo = details.RegistrationNo,
                TaxRegistrationNo = details.TaxRegistrationNo,
                IsActive = details.IsActive,
                CreatedBy = details.CreatedBy,
                CreatedOn = details.CreatedOn
            };

            return await repo.UpdateFacilityAsync(sanitizedDetails);
        }

        public async Task<bool> DelFacilityAsync([Service] IFacilityRepository productService, int facilityId)
        {
            return await productService.DeleteFacilityAsync(facilityId);
        }
    }


}
