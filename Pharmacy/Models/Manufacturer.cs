using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public bool License { get; set; }
        public virtual List<Drug> Drugs { get; set; }
    }
}
