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
                Technologies = this.GetBatteryTechnologies(),
                Capacities = this.GetBatteryCapacities(),
                Amperages = this.GetBatteryAmperages(),
                Terminals = this.GetBatteryTerminals()

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


        private IEnumerable<BatteryCapacityViewModel> GetBatteryCapacities()
        {
            return this.data
                .Capacities
                .Select(c => new BatteryCapacityViewModel
                {
                    Id = c.Id,
                    Value = c.Value
                })
                .OrderBy(c=>c.Value)
                .ToList();
        }


        private IEnumerable<BatteryAmperageViewModel> GetBatteryAmperages()
        {
            return this.data
                .Amperages
                .Select(a => new BatteryAmperageViewModel
                {
                    Id = a.Id,
                    Value = a.Value
                })
                .OrderBy(a => a.Value)
                .ToList();
        }


        private IEnumerable<BatteryTerminalsViewModel> GetBatteryTerminals()
        {
            return this.data
                .Terminals
                .Select(t => new BatteryTerminalsViewModel
                {
                    Id = t.Id,
                    Name = t.Description
                })
                .ToList();
        }
    }
}
