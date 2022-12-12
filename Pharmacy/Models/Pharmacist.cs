using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Pharmacist : People
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public virtual List<Order> Orders { get; set; }
        public int? PharmacyId { get; set; }
        public virtual Pharmacy_m Pharmacy { get; set; }
    }
}
