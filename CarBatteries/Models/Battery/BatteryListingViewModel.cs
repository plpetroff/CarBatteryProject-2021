namespace CarBatteries.Models.Battery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BatteryListingViewModel
    {
        public int Id { get; init; }

        public int BrandId { get; set; }
        public string Brand { get; set; }

        public int TechnologyId { get; set; }
        public string Technology { get; set; }

        public int CapacityId { get; set; }
        public string Capacity { get; set; }

        public int AmperageId { get; set; }
        public string Amperage { get; set; }

    }
}
