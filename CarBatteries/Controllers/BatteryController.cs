namespace CarBatteries.Controllers
{
    using CarBatteries.Data;
    using CarBatteries.Data.Models;
    using CarBatteries.Models.Battery;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.IO;
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
                Terminals = this.GetBatteryTerminals(),
                BoxTypes = this.GetBatteryBoxTypes()

            });
        }

        public IActionResult All()
        {
            var batteries = this.data
                .Batteries
                .OrderBy(b=>b.Id)
                .Select(b => new BatteryListingViewModel
                {
                    BrandId = b.BrandId,
                    Brand = b.Brand.BrandName,
                    TechnologyId = b.TechnologyId,
                    Technology = b.Technology.Name,
                    CapacityId = b.CapacityId,
                    Capacity = b.Capacity.Value.ToString(),
                    AmperageId = b.AmperageId,
                    Amperage = b.Amperage.Value.ToString()
                })
                .ToList();

            return View(new AllBatteryQueryModel 
            { 
                Batteries = batteries
            });
        }

        [HttpPost]
        public IActionResult Add(AddBatteryFormModel batteryModel, IFormFile image)
        {
            if (image == null || image.Length > 2 * 1024 * 1024)
            {
                this.ModelState.AddModelError("Image", "The image is not valid. It is required and it is should be less than 2 MB");
            }

            var imageInMemory = new MemoryStream();
            image.CopyTo(imageInMemory);
            var imageBytes = imageInMemory.ToArray();

            imageInMemory.Close();
            imageInMemory.Dispose();




            if (!this.data.Brands.Any(b => b.Id == batteryModel.BrandId))
            {
                this.ModelState.AddModelError(nameof(batteryModel.BrandId), "Brand does not exist");
            }

            if (!ModelState.IsValid)
            {
                batteryModel.Brands = this.GetBatteryBrands();
                batteryModel.Categories = this.GetBatteryCategories();
                batteryModel.Technologies = this.GetBatteryTechnologies();
                batteryModel.Capacities = this.GetBatteryCapacities();
                batteryModel.Amperages = this.GetBatteryAmperages();
                batteryModel.Terminals = this.GetBatteryTerminals();
                batteryModel.BoxTypes = this.GetBatteryBoxTypes();

                return View(batteryModel);
            }

            var battery = new Battery
            {
                BrandId = batteryModel.BrandId,
                CategoryId = batteryModel.CategoryId,
                TechnologyId = batteryModel.TechnologyId,
                CapacityId = batteryModel.CapacityId,
                AmperageId = batteryModel.AmperageId,
                TerminalsId = batteryModel.TerminalsId,
                BoxTypeId = batteryModel.BoxTypeId,
                ImageId = batteryModel.ImageId

            };

            this.data.Batteries.Add(battery);            

            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
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
                .OrderBy(c => c.Value)
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

        private IEnumerable<BatteryBoxTypeViewModel> GetBatteryBoxTypes()
        {
            return this.data
                .BoxTypes
                .Select(bt => new BatteryBoxTypeViewModel
                {
                    Id = bt.Id,
                    Name = bt.BoxTypeCode
                })
                .OrderBy(bt => bt.Name)
                .ToList();
        }

    }
}
