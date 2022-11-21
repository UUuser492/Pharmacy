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
        //public string? fName { get; set; }
        //public string? lName { get; set; }
        //public bool Gender { get; set; }
        //public int Age { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public List<Order> Orders { get; set; }
    }
}
