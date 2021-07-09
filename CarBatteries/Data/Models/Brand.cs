namespace CarBatteries.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandNameMaxLength)]
        public string BrandName { get; set; }

        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
