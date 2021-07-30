namespace CarBatteries.Models.Battery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class AllBatteryQueryModel
    {
        public IEnumerable<string> Brands { get; init; }

        [Display(Name = "Search")]
        public IEnumerable<string> SearchTerm { get; init; }

        public BatteriesSorting Sorting { get; init; }
        public IEnumerable<BatteryListingViewModel> Batteries { get; init; }
    }
}
