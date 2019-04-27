using System.Threading.Tasks;
using Core.Models;
using Infrastructure;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        private CityGuideDBContext _context;

        public PointOfInterestController(CityGuideDBContext context)
        {
            _context = context;
        }

        // GET api/pointOfInterest
        [HttpGet]
        public async Task<PagedResult<PointOfInterest>> Get(int page = 1, int pageSize = 10)
        {
            return await _context.PointsOfInterest.GetPagedAsync(page, pageSize);
        }
    }
}
