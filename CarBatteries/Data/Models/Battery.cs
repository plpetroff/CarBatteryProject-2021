namespace CarBatteries.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Battery
    {
        public int Id { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int CapacityId { get; set; }
        public Capacity Capacity { get; set; }

        public int AmperageId { get; set; }
        public Amperage Amperage { get; set; }

        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int LengthId { get; set; }
        public Length Length { get; set; }

        public int WidthId { get; set; }
        public Width Width { get; set; }

        public int HeightId { get; set; }
        public Height Height { get; set; }

        public int HeightPlusId { get; set; }
        public HeightPlus HeightPlus { get; set; }

        public int TerminalsId { get; set; }
        public Terminals Terminals { get; set; }

        public int WeightId { get; set; }
        public Weight Weight { get; set; }

        public int BoxTypeId { get; set; }
        public BoxType BoxType { get; set; }

        public int BatteryCodeId { get; set; }
        public BatteryCode BatteryCode { get; set; }

        public int PriceId { get; set; }
        public Price Price { get; set; }


    }
}
