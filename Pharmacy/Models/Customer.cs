using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Customer : People
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public virtual List<Reciept> Reciepts { get; set; }
    }
}
