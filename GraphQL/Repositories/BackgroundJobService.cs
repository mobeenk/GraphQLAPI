using GraphQL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GraphQL.Repositories
{
    public interface IBackgroundJobService
    {
        Task MyBackgroundJobAsync();
        Task<List<Order>> GetOrdersData();
    }


    public class BackgroundJobService : IBackgroundJobService
    {
        private readonly NorthwindContext _context;

        public BackgroundJobService(NorthwindContext context)
        {
            _context = context;
        }

        public async Task MyBackgroundJobAsync()
        {
            List<Order> orders = new List<Order>();
            for (int i = 0; i < 166; i++)
            {
                var query = await _context.Orders
                                            .OrderBy(o => o.OrderDate)
                                            .ToListAsync();
                orders.AddRange(query);
                // Process the query result or perform any other background task
                // Console.WriteLine($"Background job processed {query.Count} orders asynchronously. Iteration: {i + 1}");
            }
            Console.WriteLine($"Background job processed {orders.Count} orders asynchronously");
        }
        public async Task<List<Order>> GetOrdersData()
        {
            List<Order> orders = new List<Order>();
            for (int i = 0; i < 126; i++)
            {
                var query = await _context.Orders
                                            .OrderBy(o => o.OrderDate)
                                            .ToListAsync();

                // Process the query result or perform any other background task
                orders.AddRange(query);
            }
            return orders;
        }
    }


}
