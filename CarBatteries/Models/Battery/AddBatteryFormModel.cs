namespace CarBatteries.Models.Battery
{
    using CarBatteries.Data;
    using CarBatteries.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class AddBatteryFormModel
    {
        [Display(Name = "Brand of the Battery")]
        public int BrandId { get; set; }
        public IEnumerable<BatteryBrandViewModel> Brands { get; set; }


        [Display(Name = "Category of the Battery")]
        public int CategoryId { get; set; }
        public IEnumerable<BatteryCategoryViewModel> Categories { get; set; }

        public int TechnologyId { get; set; }
        public IEnumerable<BatteryTechnologyViewModel> Technologies { get; set; }


        public int CapacityId { get; set; }
        public IEnumerable<BatteryCapacityViewModel> Capacities { get; set; }


        public int AmperageId { get; set; }
        public IEnumerable<BatteryAmperageViewModel> Amperages { get; set; }

        public int BoxTypeId { get; set; }
        public IEnumerable<BatteryBoxTypeViewModel> BoxTypes { get; set; }

        public int TerminalsId { get; set; }
        public IEnumerable<BatteryTerminalsViewModel> Terminals { get; set; }


        [Display(Name = "Batteryyyy Brand")]
        public Brand Brand { get; set; }




        public int LengthId { get; set; }

        public int WidthId { get; set; }


        public int HeightId { get; set; }

        public int HeightPlusId { get; set; }



        public int WeightId { get; set; }



        public int BatteryCodeId { get; set; }

        public int PriceId { get; set; }
    }
}
