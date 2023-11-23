using GraphQL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimController :   ControllerBase
    {
        private readonly ZyklusCoreContext _context;
        private readonly ILogger<ClaimController> _logger;

        public ClaimController(ILogger<ClaimController> logger, ZyklusCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetFacilities")]
        public async Task<List<RcmFacility>> GetFacilities()
        {
            var customers = await _context.RcmFacilities.ToListAsync();
            return customers;
        }
    }
}
