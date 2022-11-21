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
        public Manufacturer Manufacturer { get; set; }
        public List<DrugType> DrugTypes { get; set; }
        public List<Order> Orders { get; set; }
        public List<Reciept> Reciepts { get; set; }
        //public int? RecieptId { get; set; } 
    }
}
