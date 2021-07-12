namespace CarBatteries.Controllers
{
    using CarBatteries.Data;
    using CarBatteries.Models.Battery;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BatteryController : Controller
    {
        private readonly CarBatteriesDbContext data;

        public BatteryController(CarBatteriesDbContext data)
        {
            this.data = data;
        }
        public IActionResult Add()
        {
            return View(new AddBatteryFormModel
            { 
                Brands = this.GetBatteryBrands(),
                Categories = this.GetBatteryCategories(),
                Technologies = this.GetBatteryTechnologies()
                
            });
        }

        [HttpPost]
        public IActionResult Add(AddBatteryFormModel batteryModel)
        {
            return View();
        }

        private IEnumerable<BatteryBrandViewModel> GetBatteryBrands()
        {
            return this.data
                    .Brands
                    .Select(b => new BatteryBrandViewModel
                    {
                        Id = b.Id,
                        Name = b.BrandName
                    })
                    .ToList();
        }


        private IEnumerable<BatteryCategoryViewModel> GetBatteryCategories()
        {
            return this.data
                .Categories
                .Select(c => new BatteryCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.CategoryName
                })
                .ToList();
        }

        private IEnumerable<BatteryTechnologyViewModel> GetBatteryTechnologies()
        {
            return this.data
                .Technologies
                .Select(t => new BatteryTechnologyViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToList();
        }
    }
}
