using GraphQL.Models;
using GraphQL.Schema;

namespace GraphQL.Queries
{

    public class Query
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
    }

}
