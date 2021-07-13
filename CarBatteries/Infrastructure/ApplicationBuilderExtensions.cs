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

            SeedBrands(data);
            SeedCategories(data);
            SeedTechnologies(data);
            SeedCapacities(data);
            SeedAmperages(data);            
            SeedBoxType(data);
            SeedTerminals(data);

            return app;
        }

        private static void SeedBrands(CarBatteriesDbContext data)
        {
            if (data.Brands.Any())
            {
                return;
            }

            data.Brands.AddRange(new[]
            {
                new Brand{ BrandName = "Cronus"},
                new Brand{ BrandName = "Varta"},
                new Brand{ BrandName = "Bosch"},
                new Brand{ BrandName = "Amper"},
                new Brand{ BrandName = "FREE MAX"},
                new Brand{ BrandName = "X-PRO"},


            });

            data.SaveChanges();
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

        private static void SeedCapacities(CarBatteriesDbContext data)
        {
            if (data.Capacities.Any())
            {
                return;
            }

            data.Capacities.AddRange(new[]
            {
                new Capacity{ Value = 35},
                new Capacity{ Value = 34},
                new Capacity{ Value = 45},
                new Capacity{ Value = 46},
                new Capacity{ Value = 48},
                new Capacity{ Value = 50},
                new Capacity{ Value = 54},
                new Capacity{ Value = 55},
                new Capacity{ Value = 60},
                new Capacity{ Value = 62},
                new Capacity{ Value = 65},
                new Capacity{ Value = 68},
                new Capacity{ Value = 70},
                new Capacity{ Value = 72},
                new Capacity{ Value = 75},
                new Capacity{ Value = 77},
                new Capacity{ Value = 80},
                new Capacity{ Value = 82},
                new Capacity{ Value = 85},
                new Capacity{ Value = 90},
                new Capacity{ Value = 94},
                new Capacity{ Value = 95},
                new Capacity{ Value = 100},
                new Capacity{ Value = 105},
                new Capacity{ Value = 110},
                new Capacity{ Value = 120},
                new Capacity{ Value = 125},
                new Capacity{ Value = 130},
                new Capacity{ Value = 140},
                new Capacity{ Value = 150},
                new Capacity{ Value = 165},
                new Capacity{ Value = 180},
                new Capacity{ Value = 200},
                new Capacity{ Value = 220},
                new Capacity{ Value = 225},
                new Capacity{ Value = 230},
                new Capacity{ Value = 240},
                


            });

            data.SaveChanges();
        }

        private static void SeedAmperages(CarBatteriesDbContext data)
        {
            if (data.Amperages.Any())
            {
                return;
            }

            data.Amperages.AddRange(new[]
            {
                new Amperage{ Value = 300},
                new Amperage{ Value = 380},
                new Amperage{ Value = 400},
                new Amperage{ Value = 420},
                new Amperage{ Value = 430},
                new Amperage{ Value = 450},
                new Amperage{ Value = 460},
                new Amperage{ Value = 480},
                new Amperage{ Value = 500},
                new Amperage{ Value = 510},
                new Amperage{ Value = 540},
                new Amperage{ Value = 550},
                new Amperage{ Value = 580},
                new Amperage{ Value = 600},
                new Amperage{ Value = 630},
                new Amperage{ Value = 650},
                new Amperage{ Value = 680},
                new Amperage{ Value = 700},
                new Amperage{ Value = 720},
                new Amperage{ Value = 730},
                new Amperage{ Value = 750},
                new Amperage{ Value = 780},
                new Amperage{ Value = 800},
                new Amperage{ Value = 820},
                new Amperage{ Value = 830},
                new Amperage{ Value = 840},
                new Amperage{ Value = 850},
                new Amperage{ Value = 900},
                new Amperage{ Value = 920},
                new Amperage{ Value = 950},
                new Amperage{ Value = 1000},
                new Amperage{ Value = 1100},
                new Amperage{ Value = 1200},
                new Amperage{ Value = 1300},
                new Amperage{ Value = 1400}                


            });

            data.SaveChanges();
        }

        private static void SeedBoxType(CarBatteriesDbContext data)
        {
            if (data.BoxTypes.Any())
            {
                return;
            }

            data.BoxTypes.AddRange(new[]
            {
                new BoxType{ BoxTypeCode = "L0"},
                new BoxType{ BoxTypeCode = "L1"},
                new BoxType{ BoxTypeCode = "LB1"},
                new BoxType{ BoxTypeCode = "L2"},
                new BoxType{ BoxTypeCode = "LB2"},
                new BoxType{ BoxTypeCode = "L3"},
                new BoxType{ BoxTypeCode = "LB3"},
                new BoxType{ BoxTypeCode = "L4"},
                new BoxType{ BoxTypeCode = "LB4"},
                new BoxType{ BoxTypeCode = "L5"},
                new BoxType{ BoxTypeCode = "LB5"},
                new BoxType{ BoxTypeCode = "L6"},
                new BoxType{ BoxTypeCode = "LB6"},
                new BoxType{ BoxTypeCode = "B19"},
                new BoxType{ BoxTypeCode = "B24"},
                new BoxType{ BoxTypeCode = "D20"},
                new BoxType{ BoxTypeCode = "D23"},
                new BoxType{ BoxTypeCode = "D26"},
                new BoxType{ BoxTypeCode = "D31"},
                new BoxType{ BoxTypeCode = "M24"},
                new BoxType{ BoxTypeCode = "M27"},
                new BoxType{ BoxTypeCode = "M31"},
                new BoxType{ BoxTypeCode = "A"},
                new BoxType{ BoxTypeCode = "B"},
                new BoxType{ BoxTypeCode = "C"},
                new BoxType{ BoxTypeCode = "MAC 110"},
                new BoxType{ BoxTypeCode = "MAC 143"},
                new BoxType{ BoxTypeCode = "MAC 155"},


            });

            data.SaveChanges();
        }

        private static void SeedTerminals(CarBatteriesDbContext data)
        {
            if (data.Terminals.Any())
            {
                return;
            }

            data.Terminals.AddRange(new[]
            {
                new Terminals{ Description = "R + Standart"},
                new Terminals{ Description = "L + Standart"},
                new Terminals{ Description = "R + Small"},
                new Terminals{ Description = "L + Small"},
                new Terminals{ Description = "Side"},
                new Terminals{ Description = "Marine twin"},
                new Terminals{ Description = "Stud"},
                new Terminals{ Description = "Dual"},
                new Terminals{ Description = "Top"},

            });

            data.SaveChanges();
        }
    }
}
