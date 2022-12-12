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
        public virtual Pharmacist Pharmacist { get; set; }
        public int? DrugId { get; set;  }
        public virtual Drug Drug { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }
    }
}
