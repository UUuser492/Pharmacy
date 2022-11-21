using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class DrugType
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public Drug Drug { get; set; }
        public int? Pharmacy_mId { get; set; }
        public Pharmacy_m Pharmacy { get; set; }
        public int Amount { get; set; }
    }
}
