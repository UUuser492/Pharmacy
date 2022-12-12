using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Drug
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public decimal Price { get; set; }
        public int? ManufacturerId { get; set; }//no on delete cascade
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual List<DrugType> DrugTypes { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Reciept> Reciepts { get; set; } 
    }
}
