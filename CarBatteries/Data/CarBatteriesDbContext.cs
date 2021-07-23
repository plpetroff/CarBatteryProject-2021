
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
        public DbSet<Terminals> Terminals { get; init; }
        public DbSet<BoxType> BoxTypes { get; init; }
        public DbSet<BatteryCode> BatteryCodes { get; init; }
        public DbSet<Image> Images { get; init; }



        //public DbSet<Price> Prices { get; init; }
        //public DbSet<Length> Lengths { get; init; }
        //public DbSet<Width> Widths { get; init; }
        //public DbSet<Height> Heights { get; init; }
        //public DbSet<HeightPlus> HeightsPluses { get; init; }
        //public DbSet<Weight> Weights { get; init; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Battery>()
                .HasOne(b => b.Brand)
                .WithMany(br => br.Batteries)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Capacity)
                .WithMany(c => c.Batteries)
                .HasForeignKey(b => b.CapacityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Amperage)
                .WithMany(a => a.Batteries)
                .HasForeignKey(b => b.AmperageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Technology)
                .WithMany(t => t.Batteries)
                .HasForeignKey(b => b.TechnologyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Batteries)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.Length)
            //    .WithMany(l => l.Batteries)
            //    .HasForeignKey(b => b.LengthId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.Width)
            //    .WithMany(w => w.Batteries)
            //    .HasForeignKey(b => b.WidthId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.Height)
            //    .WithMany(h => h.Batteries)
            //    .HasForeignKey(b => b.HeightId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.HeightPlus)
            //    .WithMany(h => h.Batteries)
            //    .HasForeignKey(b => b.HeightPlusId)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Terminals)
                .WithMany(t => t.Batteries)
                .HasForeignKey(b => b.TerminalsId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.Weight)
            //    .WithMany(w => w.Batteries)
            //    .HasForeignKey(b => b.WeightId)
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.BoxType)
                .WithMany(bx => bx.Batteries)
                .HasForeignKey(b => b.BoxTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //   .Entity<Battery>()
            //    .HasOne(b => b.BatteryCode)
            //    .WithOne(bc => bc.Battery)
            //    .HasForeignKey<Battery>(b => b.BatteryCodeId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Entity<Battery>()
            //    .HasOne(b => b.Price)
            //    .WithMany(p => p.Batteries)
            //    .HasForeignKey(b => b.PriceId)
            //    .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

    }
}
