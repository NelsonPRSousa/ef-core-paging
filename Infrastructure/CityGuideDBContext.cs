using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class CityGuideDBContext : DbContext
    {
        public CityGuideDBContext(DbContextOptions<CityGuideDBContext> options) : base(options)
        {
        }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}
