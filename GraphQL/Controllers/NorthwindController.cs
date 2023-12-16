using GraphQL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NorthwindController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<NorthwindController> _logger;
        private readonly NorthwindContext _context;

        public NorthwindController(ILogger<NorthwindController> logger, NorthwindContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            var customers = _context.Customers.AsNoTracking().ToList();
            return customers;
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})dw
            //.ToArray();
        }
        [HttpGet("GetOrdersCount")]
        public async Task<IActionResult> GetOrdersCount()
        {
            var result =await _context.Orders.CountAsync();
            return Ok(result);
        }
        [HttpGet("GetOrdersPaginated")]
        public async Task<IActionResult> GetOrdersPaginated(int pageNumber = 1, int pageSize = 10)
        {
            IQueryable<Order> query;
            //if (user == "Admin") // Check if user has admin role
            query = _context.Orders;
            //else if (user == "User") // Check if user has user role
            //    query = _context.Orders.Where(o => o.ShipVia == 1);
            //else
            //    return Forbid(); // Return 403 Forbidden if user role is not recognized
            query = query
                .OrderBy(o => o.OrderId)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            var result =await query.ToListAsync();
            
            return Ok(result);
        }
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            var query = _context.Orders
                .OrderBy(o => o.OrderDate)
                .ToList();

            return Ok(query);

        }
        [HttpGet("GetTask1")]
        public async Task<IActionResult> GetTask1()
        {
            await Task.Delay(5000);

            return Ok(1);
        }
        [HttpGet("GetTask2")]
        public async Task<IActionResult> GetTask2()
        {
            await Task.Delay(3000);

            return Ok(2);
        }


        [HttpGet("GetLinq")]
        public async Task<IActionResult> GetLinq()
        {

            var query = from order in _context.Orders
                        join orderDetail in _context.OrderDetails on order.OrderId equals orderDetail.OrderId into orderDetailsGroup
                        from orderDetail in orderDetailsGroup.DefaultIfEmpty()
                        join product in _context.Products on orderDetail.ProductId equals product.ProductId into productsGroup
                        from product in productsGroup.DefaultIfEmpty()
                        select new
                        {
                            OrderID = order.OrderId,
                            OrderDate = order.OrderDate,
                            ShipVia = order.ShipVia,
                            ProductID = product.ProductId,
                            ProductName = product.ProductName
                        };

            var result = await  query.ToListAsync();
            return Ok(query);

        }
    }
}