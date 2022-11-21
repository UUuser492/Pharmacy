using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? PharmacistId { get; set; }
        public Pharmacist Pharmacist { get; set; }
        public int? DrugId { get; set;  }
        public Drug Drug { get; set; }
        //public List<Drug> Drugs { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }
    }
}
