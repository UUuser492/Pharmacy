using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;

namespace Pharmacy
{
    public class Add_Delete
    {
        public Add_Delete() { }
        
        public PharmacyContextFactory PharmacyContextFactory = new PharmacyContextFactory(); 

        public void Add_Drug_Manufacturer(int DrugId, string DrugName, decimal Price, string ManufacturerName, string ManufacturerAddress)
        {
            using (var ctx = PharmacyContextFactory.CreateDbContext(new string[] {}))
            {
                Drug drug = new Drug() { Name = DrugName, Price = Price, Type = "test", Manufacturer = new Manufacturer() { Name = ManufacturerName, Address = ManufacturerAddress, License = true } };
                ctx.Add(drug);
                
                ctx.SaveChanges();

            }
        }

        public void Delete_Drug_Manufacturer(int to_delete)
        {
            using (var ctx = PharmacyContextFactory.CreateDbContext(new string[] { }))
            {
                foreach(var del in ctx.Manufacturer.ToList())
                {
                    if(del.Id == to_delete)
                    {
                        ctx.Manufacturer.Remove(del);
                    }
                }

                foreach (var del in ctx.Drugs.ToList())
                {
                    if (del.Id == to_delete)
                    {
                        ctx.Drugs.Remove(del);
                    }
                }

                ctx.SaveChanges();
            }
        }
    }
}
