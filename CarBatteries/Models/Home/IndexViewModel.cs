namespace CarBatteries.Models.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IndexViewModel
    {
        public int TotalBatteries { get; init; }

        public int TotalUsers { get; init; }

        public List<BatteryIndexViewModel> Batteries { get; init; }


    }
}
