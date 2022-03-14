namespace CarBatteries.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using static DataConstants;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; }

        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
