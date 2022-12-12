using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Pharmacy_m
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public virtual List<DrugType> DrugTypes { get; set; }
        public virtual List<Pharmacist> Pharmacists { get; set; }
    }
}
