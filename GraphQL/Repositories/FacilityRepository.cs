using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Repositories
{
    public interface IFacilityRepository
    {
        Task<bool> AddFacilityAsync(RcmFacility newFacility);
        Task<bool> DeleteFacilityAsync(int facilityId);
        Task<bool> UpdateFacilityAsync(RcmFacility updateFacility);
        Task<List<RcmFacility>> FacilityListAsync();
    }
    public class FacilityRepository : IFacilityRepository
    {
        private readonly ZyklusCoreContext _context;
        public FacilityRepository(ZyklusCoreContext context)
        {
            _context = context;
        }
        public async Task<List<RcmFacility>> FacilityListAsync()
        {
            return await _context.RcmFacilities.ToListAsync();
        }
        public async Task<bool> AddFacilityAsync(RcmFacility newFacility)
        {
            try
            {
                var savedFacility = (await _context.RcmFacilities.AddAsync(newFacility)).Entity;
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        private bool ProductDetailsExists(int facilityId)
        {
            return _context.RcmFacilities.Any(e => e.FacilityId == facilityId);
        }
        public async Task<bool> UpdateFacilityAsync(RcmFacility updateFacility)
        {
            var isProduct = ProductDetailsExists(updateFacility.FacilityId);
            if (isProduct)
            {
                _context.RcmFacilities.Update(updateFacility);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public async Task<bool> DeleteFacilityAsync(int facilityId)
        {
            try
            {
                var getFacility = (await _context.RcmFacilities.Where(x => x.FacilityId == facilityId).FirstOrDefaultAsync());
                if (getFacility != null)
                {
                    _context.RcmFacilities.Remove(getFacility);
                    var result = await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
        
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }




}
