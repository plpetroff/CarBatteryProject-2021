
namespace CarBatteries.Data
{
    using CarBatteries.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CarBatteriesDbContext : IdentityDbContext
    {

        public CarBatteriesDbContext(DbContextOptions<CarBatteriesDbContext> options)
            : base(options)
        {

        }
        public DbSet<Battery> Batteries { get; init; }
        public DbSet<Brand> Brands { get; init; }
        public DbSet<Capacity> Capacities { get; init; }
        public DbSet<Amperage> Amperages { get; init; }
        public DbSet<Technology> Technologies { get; init; }
        public DbSet<Category> Categories { get; init; }
        public DbSet<Length> Lengths { get; init; }
        public DbSet<Width> Widths { get; init; }
        public DbSet<Height> Heights { get; init; }
        public DbSet<HeightPlus> HeightsPluses { get; init; }
        public DbSet<Terminals> Terminals { get; init; }
        public DbSet<Weight> Weights { get; init; }
        public DbSet<BoxType> BoxTypes { get; init; }
        public DbSet<BatteryCode> BatteryCodes { get; init; }
        public DbSet<Price> Prices { get; init; }
        


    }
}
