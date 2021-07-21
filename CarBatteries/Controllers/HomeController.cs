
namespace CarBatteries.Controllers
{
using System;
using System.Collections.Generic;
using System.Diagnostics;
using CarBatteries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
    using CarBatteries.Data;
    using CarBatteries.Models.Battery;
    using CarBatteries.Models.Home;

    public class HomeController : Controller
    {
        private readonly CarBatteriesDbContext data;
        public HomeController(CarBatteriesDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            var totalBatteries = this.data.Batteries.Count();

            var batteries = this.data
                .Batteries
                .OrderBy(b => b.Id)
                .Select(b => new BatteryIndexViewModel
                {
                    BrandId = b.BrandId,
                    Brand = b.Brand.BrandName,
                    TechnologyId = b.TechnologyId,
                    Technology = b.Technology.Name,
                    CapacityId = b.CapacityId,
                    Capacity = b.Capacity.Value.ToString()
                    
                })
                .Take(3)
                .ToList();



            return View(new IndexViewModel 
            { 
                TotalBatteries = totalBatteries,
                Batteries = batteries
            });
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
