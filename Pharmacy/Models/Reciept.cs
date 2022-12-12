using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Reciept
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int? DrugId { get; set; }
        public virtual Drug Drug { get; set; }
        public int? OrderId { get; set; }
        public int Amount { get; set; }
        public DateTime? Created { get; set; }
    }
}
