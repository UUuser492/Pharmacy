using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pharmacy;
using Pharmacy.Models;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("config.json");
var config = builder.Build();
string? connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<PharmacyContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (var ctx = new PharmacyContext(options))
{
    Add_Delete adding = new Add_Delete();
    //adding.Add_Drug_Manufacturer(4, "Paracetamol", 55, "Farmson", "Balzaka 77");
    //adding.Delete_Drug_Manufacturer(12);



    ///////////////////////////////////////////////////////////////////////
    //var manufacturer = new Manufacturer() { Name = "TestManufacturer" };
    //var drug = new Drug() { Name = "TestDrug", Manufacturer = manufacturer };
    //var manufacturer2 = new Manufacturer() { Name = "TestManufacturer2" };
    //var drug2 = new Drug() { Name = "TestDrug2", Manufacturer = manufacturer2 };
    //ctx.Drugs.Add(drug);
    //ctx.Drugs.Add(drug2);

    //var cus = new Customer() { lName = "2", fName = "1" };
    //ctx.Customer.Add(cus);

    //var ph = new Pharmacist() { lName = "2", fName = "1" };
    //ctx.Pharmacist.Add(ph);

    //var ord = new Order() { Manufacturer = manufacturer, Pharmacist = ph };
    //ctx.Order.Add(ord);

    //var rec = new Reciept() { Drug = drug, Amount = 3 };
    //ctx.Reciept.Add(rec);

    //var phar = new Pharmacy_m() { Address = "test" };
    //ctx.Pharmacy.Add(phar);

    //var DT = new DrugType() { Drug = drug, Pharmacy = phar };
    //ctx.DrugType.Add(DT);

    //ctx.SaveChanges();
    /////////////////////////////////////////////////////////////////////////////////////////

    //foreach(var a in drugs)
    //{
    //    Console.WriteLine(a.Name);
    //}

    //var drugs = ctx.Drugs.Where(drugs => drugs.Name == "TestDrug2").Single();
    //drugs.Price = 150.1M;
    //ctx.SaveChanges();
};
