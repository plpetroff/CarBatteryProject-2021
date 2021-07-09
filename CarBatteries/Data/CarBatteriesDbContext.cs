
namespace CarBatteries.Data
{
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
    }
}
