using System;
using System.Linq;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Utils
{
    public class FakeDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CityGuideDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<CityGuideDBContext>>()))
            {
                // Look for any points of interest already in database
                if (context.PointsOfInterest.Any())
                {
                    return; // Database has been seeded
                }

                for (int i = 1; i <= 100; i++)
                {
                    context.PointsOfInterest.Add(new PointOfInterest() { Id = i });
                }

                context.SaveChanges();
            }
        }
    }
}
