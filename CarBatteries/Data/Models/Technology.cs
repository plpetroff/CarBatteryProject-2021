namespace CarBatteries.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Technology
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
