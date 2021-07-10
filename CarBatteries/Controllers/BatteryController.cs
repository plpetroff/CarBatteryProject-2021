namespace CarBatteries.Controllers
{
    using CarBatteries.Models.Battery;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BatteryController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBatteryFormModel batteryModel)
        {
            return View();
        }
    }
}
