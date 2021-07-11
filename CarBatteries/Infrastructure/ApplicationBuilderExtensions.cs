namespace CarBatteries.Infrastructure
{
    using CarBatteries.Data;
    using Microsoft.AspNetCore.Builder;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using CarBatteries.Data.Models;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<CarBatteriesDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(CarBatteriesDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category{ CategoryName = "SMF/ME"},
                new Category{ CategoryName = "MF/K"},
                new Category{ CategoryName = "JIS"},
                new Category{ CategoryName = "TRUCK SMF"},
                new Category{ CategoryName = "TRUCK K"},
                new Category{ CategoryName = "Marine"},
                new Category{ CategoryName = "Solar"},
                new Category{ CategoryName = "Moto"},

            });

            data.SaveChanges();
        }


        private static void SeedTechnologies(CarBatteriesDbContext data)
        {
            if (data.Technologies.Any())
            {
                return;
            }

            data.Technologies.AddRange(new[]
            {
                new Technology{ Name = "Calcium"},
                new Technology{ Name = "AGM"},
                new Technology{ Name = "EFB"},
                new Technology{ Name = "Gel"},                
                new Technology{ Name = "VRLA"},                

            });

            data.SaveChanges();
        }
    }
}
