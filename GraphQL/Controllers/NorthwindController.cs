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
        [HttpGet("GetOrdersPaginated")]
        public IActionResult GetOrdersPaginated(int pageNumber = 1, int pageSize = 10)
        {
            var query = _context.Orders
                .OrderBy(o => o.OrderDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(query);

        }
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            var query = _context.Orders
                .OrderBy(o => o.OrderDate)
                .ToList();

            return Ok(query);

        }
    }
}