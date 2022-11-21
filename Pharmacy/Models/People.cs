using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class People
    {
        public string? fName { get; set; }
        public string? lName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
    }
}
