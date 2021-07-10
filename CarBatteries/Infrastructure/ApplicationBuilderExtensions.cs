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
                new Category{ CategoryName = "SMF Power"},
                new Category{ CategoryName = "Truck"},
                new Category{ CategoryName = "Truck SMF"},
                new Category{ CategoryName = "Marine"},
                new Category{ CategoryName = "EFB"},
                new Category{ CategoryName = "AGM"},

            });
        }
    }
}
