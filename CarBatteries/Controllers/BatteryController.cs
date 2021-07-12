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
                Brands = this.GetBatteryBrands()
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
    }
}
