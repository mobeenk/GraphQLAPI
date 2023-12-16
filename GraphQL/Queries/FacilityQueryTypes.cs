using GraphQL.Models;
using GraphQL.Repositories;

namespace GraphQL.Queries
{

    public class FacilityQueryTypes
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Product> GetProducts([Service] NorthwindContext context) =>  context.Products;
        //new List<Product>().AsQueryable();
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Customer> GetCustomers([Service] NorthwindContext context) => context.Customers;

        //Zylucs
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<RcmFacility> GetFacilities([Service] ZyklusCoreContext db) => db.RcmFacilities;

        //Slower
        public async Task<List<RcmFacility>> GetFacilityListAsync([Service] IFacilityRepository productService)
        {
            return await productService.FacilityListAsync();
        }
    }

}
