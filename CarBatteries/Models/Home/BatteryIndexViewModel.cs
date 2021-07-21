namespace CarBatteries.Models.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BatteryIndexViewModel
    {
        public int Id { get; init; }

        public int BrandId { get; set; }
        public string Brand { get; set; }

        public int TechnologyId { get; set; }
        public string Technology { get; set; }

        public int CapacityId { get; set; }
        public string Capacity { get; set; }

        
    }
}
