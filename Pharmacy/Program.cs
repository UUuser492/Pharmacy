using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using System.Threading;
using Pharmacy;
using Pharmacy.Models;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.PortableExecutable;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("config.json");
var config = builder.Build();
string? connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<PharmacyContext>();
var options = optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString).Options;


using (var ctx = new PharmacyContext(options))
{
    //Add_Delete adding = new Add_Delete();
    //adding.Add_Drug_Manufacturer(4, "Paracetamol", 55, "Farmson", "Balzaka 77");
    //adding.Delete_Drug_Manufacturer(14); // -> rand id


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
    /////////////////////////////////////////////////////////////////////////////////////////L3

    ////select drugs, where id of manufacturer = 1 & 3
    //var dr = ctx.Drugs.Include(p => p.Manufacturer).Where(p => p.ManufacturerId == 1 || p.ManufacturerId == 3).ToList();
    //foreach (Drug drugs in dr)
    //    Console.WriteLine(drugs.Name);

    ////select drugs from "Yassen manufacturer" also
    //var Drugs = ctx.Drugs.Where(p => p.Manufacturer!.Name == "Yassen");
    //foreach (Drug dr1 in Drugs)
    //    Console.WriteLine($"{dr1.Name} ({dr1.Manufacturer.Name})");

    ////projection
    //var dr = ctx.Drugs.Select(p => new
    //{
    //    Name = p.Name,
    //    M_name = p.Manufacturer.Name,
    //    M_id = p.ManufacturerId,
    //    Ph_Order = p.Orders.First().Created,
    //    //Ph_name = p.Orders.First().Pharmacist.fName,
    //    Ph_name2 = p.Orders.First().Pharmacist.lName,
    //    D_Amount = p.Orders.First().Amount,
    //    Ph_pharmacy_Add = p.Orders.First().Pharmacist.Pharmacy.Address,
    //});
    //foreach (var drugs in dr)
    //    Console.WriteLine($"({drugs.M_name}) - {drugs.M_id}; " +
    //        //$"{drugs.Ph_name}" +
    //        $" {drugs.Ph_name2} " +
    //        $"ordered at {drugs.Ph_Order} {drugs.Name}; " +
    //        $"amount is: {drugs.D_Amount}; " +
    //        $"at address: {drugs.Ph_pharmacy_Add}");

    ////sort by name
    //var drugs = ctx.Drugs.OrderBy(p => p.Name);
    //foreach (var drug in drugs)
    //    Console.WriteLine($"{drug.Id}.{drug.Name}");

    ////join drugs with manufacturers
    //var drugs = ctx.Drugs.Join(ctx.Manufacturer, // второй набор
    //    u => u.ManufacturerId, // свойство-селектор объекта из первого набора
    //    c => c.Id, // свойство-селектор объекта из второго набора
    //    (u, c) => new // результат
    //    {
    //        Name = u.Name,
    //        Manufacturer = c.Name,
    //        Price = u.Price
    //    });
    //foreach (var u in drugs)
    //    Console.WriteLine($"{u.Name} ({u.Manufacturer}) - {u.Price}");

    ////group by License(3 manufacturers)
    //var Drug_group = ctx.Drugs.GroupBy(d => d.Manufacturer!.License).Select(g => new
    //{
    //    g.Key,
    //    Count = g.Count()
    //});
    //foreach (var group in Drug_group)
    //{
    //    Console.WriteLine($"{group.Key} - {group.Count}");
    //}

    ////union for age > 19 and first name starts with "Ol"
    //var customers = ctx.Customer.Where(c => c.Age > 19)
    //    .Union(ctx.Customer.Where(c => c.fName!.StartsWith("Ol")));
    //foreach (var cust in customers)
    //    Console.WriteLine(cust.fName);

    //////intersect where price < 75 and type of "Розчинний"
    //var drugs = ctx.Drugs.Where(d => d.Price < 75)
    //    .Intersect(ctx.Drugs.Where(d => d.Type!.StartsWith("Розчинний")));
    //foreach (var dr in drugs)
    //    Console.WriteLine(dr.Name);

    ////except
    //var selector1 = ctx.Drugs.Where(d => d.Price < 75);
    //var selector2 = ctx.Drugs.Where(d => d.Type!.StartsWith("Розчинний"));
    //var drugs = selector1.Except(selector2);
    //foreach (var drug in drugs)
    //    Console.WriteLine(drug.Name);

    ////distinct by gender
    //var DisCusts = ctx.Customer.ToList();
    //foreach (var item in DisCusts.DistinctBy(c => c.Gender))
    //{
    //    Console.WriteLine(item.fName);
    //}

    ////any agr_f
    //bool _any = ctx.Customer.Any(c => c.Gender == false);
    //Console.WriteLine(_any);

    ////all agr_f
    //bool _all = ctx.Pharmacist.All(c => c.Gender == true);
    //Console.WriteLine(_all);

    ////Count agr_f
    //int Am_of_drugs = ctx.Drugs.Count(d => d.Price < 100);
    //Console.WriteLine(Am_of_drugs);

    ////Min/Max/Avg
    //decimal Min, Max, Avg;
    //Min = ctx.Drugs.Min(d => d.Price);
    //Max = ctx.Drugs.Max(d => d.Price);
    //Avg = ctx.Drugs.Average(d => d.Price);
    //Console.WriteLine($"Min:{Min.ToString("G29")}; Max:{Max.ToString("G29")}; Average:{Avg.ToString("G29")}");

    ////sum
    //decimal SumPrice = ctx.Drugs.Where(d => d.Price > 20).Sum(s => s.Price);
    //Math.Round(SumPrice, 0);
    //Console.WriteLine(SumPrice.ToString("G29"));

    ////Eager loading
    //var drugs = ctx.Drugs
    //               .Include(m => m.Manufacturer)
    //               .Where(s => s.Name == "Синупрет");
    //foreach (var dr in drugs)
    //{
    //    Console.WriteLine($"{dr.Name} - {dr.Manufacturer.Name}");
    //}

    ////Explicit loading
    //Manufacturer? manuf = ctx.Manufacturer.FirstOrDefault();
    //if (manuf != null)
    //{
    //    ctx.Drugs.Where(u => u.ManufacturerId == manuf.Id).Load();

    //    Console.WriteLine($"Manufacturer: {manuf.Name}");
    //    foreach (var u in manuf.Drugs)
    //        Console.WriteLine($"Drug: {u.Name}");
    //}

    ////Lazy loading -> virtuals for LL
    //var _Drugs = ctx.Drugs.ToList();
    //foreach (Drug dr in _Drugs)
    //    Console.WriteLine($"{dr.Name} - {dr.Manufacturer?.Name}");

    ////No tracking
    //var cust = ctx.Customer.AsNoTracking().OrderBy(c => c.Id).LastOrDefault();
    //if (cust != null)
    //{
    //   cust.Age = 20;
    //   cust.fName = "Andrii";
    //    ctx.SaveChanges();
    //}
    //
    //var custs = ctx.Customer.AsNoTracking().ToList();
    //foreach (var c in custs)
    //    Console.WriteLine($"{c.fName} ({c.Age})");

    ////Tracking
    //var cust = ctx.Customer.OrderBy(c => c.Id).LastOrDefault();
    //if (cust != null)
    //{
    //    cust.Age = 20;
    //    cust.fName = "Andrii";
    //    ctx.SaveChanges();
    //}
    //
    //var custs = ctx.Customer.AsNoTracking().ToList();
    //foreach (var c in custs)
    //    Console.WriteLine($"{c.fName} ({c.Age})");

    ////stored t-function to find
    //SqlParameter param = new SqlParameter("@price", 75m);
    //var users = ctx.Drugs.FromSqlRaw("SELECT * FROM DrugsPrice (@price)", param).ToList();
    //foreach (var u in users)
    //    Console.WriteLine($"{u.Name} - {u.Price}");

    ////stored t-function to find bigger
    //SqlParameter param = new SqlParameter("@price", 20m);
    //var users = ctx.Drugs.FromSqlRaw("SELECT * FROM DrugsPriceMore (@price)", param).ToList();
    //foreach (var u in users)
    //    Console.WriteLine($"{u.Name} - {u.Price}");

    ////stored t-function to find smaller
    //SqlParameter param = new SqlParameter("@price", 75m);
    //var users = ctx.Drugs.FromSqlRaw("SELECT * FROM DrugsPriceLess (@price)", param).ToList();
    //foreach (var u in users)
    //    Console.WriteLine($"{u.Name} - {u.Price}");

    //usage from context 
    //var drugs = ctx.DrugsPriceLess(30);
    //foreach (var d in drugs)
    //    Console.WriteLine($"{d.Name} - {d.Price}");

    //StoredProcedure
    //SqlParameter param = new()
    //{
    //    ParameterName = "@type",
    //    SqlDbType = System.Data.SqlDbType.VarChar,
    //    Direction = System.Data.ParameterDirection.Output,
    //    Size = 50
    //};
    //ctx.Database.ExecuteSqlRaw("ForType @type OUT", param);
    //Console.WriteLine(param.Value);


    ////топ 3 виробники з найбільшим грошовим виторгом
    //var drugs = ctx.Drugs.Join(ctx.Reciept, m => m.Id, c => c.Id, 
    //    (m, c) => new //res
    //    {
    //        Name = m.Name,
    //        Amount = c.Amount,
    //        Price = m.Price * c.Amount,
    //        Manufacturer = m.Manufacturer.Name
    //    }).OrderByDescending(p => p.Price).Take(3);
    //foreach (var m in drugs)
    //    Console.WriteLine($"{m.Name} Amount:({m.Amount}) - Price:({m.Price}) - {m.Manufacturer}");

    ////////////////////////////////////////////////////////////////////////
    
};
//////////////////////////////////////////////////

//Insert____________________________________________________
int counter = 1;
AutoResetEvent waitHandler = new AutoResetEvent(true);
object locker = new();
Semaphore sem = new Semaphore(1, 2);
Mutex mutexObj = new();

//ThreadsInsert(); - filling with threads
//TasksInsert(); - filling with tasks
//ThreadsRead(); - semaphore/mutex reading with threads
//TasksPrint(); - async reading with tasks

void Insert()
{
    using (var ctx1 = new PharmacyContext(options))
    {
        //bool acquiredLock = false;
        //try
        //{
        //Monitor.Enter(locker, ref acquiredLock);

        //waitHandler.WaitOne();

        //sem.WaitOne();

        //lock (locker)
        //{
        mutexObj.WaitOne();
        for (int i = 0; i < 100; i++)
        {
            Drug drug = new Drug()
            {
                Name = "test" + $"{counter}",
                Price = counter,
                Type = "test" + $"{counter}",
                Manufacturer = new Manufacturer() { Name = "test" + $"{counter}", Address = "test" + $"{counter}", License = true }
            };
            Console.WriteLine($"{Thread.CurrentThread.Name}");
            ctx1.Drugs.Add(drug);
            ctx1.SaveChanges();
            counter++;
        }
        mutexObj.ReleaseMutex();
        //}

        //sem.Release();

        //waitHandler.Set();

        //}
        //finally { if (acquiredLock) Monitor.Exit(locker); }
    }
    
};

void ThreadsInsert()
{
    for(int i = 1; i <= 4; i++)
    {
        Thread myThread1 = new Thread(Insert);
        myThread1.Name = $"{i}";
        myThread1.Start();
    }
}

void ThreadsRead()
{
    for (int i = 1; i <= 4; i++)
    {
        Thread myThread1 = new Thread(Read);
        myThread1.Name = $"{i}";
        myThread1.Start();
    }
}

void ThreadsReadAsync()
{
    for (int i = 1; i <= 4; i++)
    {
        Thread myThread1 = new Thread(Read);
        myThread1.Name = $"{i}";
        myThread1.Start();
    }
}

//Semaphore & Mutex reading___________________________________
void Read()
{

    mutexObj.WaitOne();
    //sem.WaitOne();
    using (var ctx1 = new PharmacyContext(options))
    {
        var drugs = (from d in ctx1.Drugs
                     orderby d.Price
                     select d).ToList();
        foreach (var m in drugs)
            Console.WriteLine($"{Thread.CurrentThread.Name} {m.Name} - Price:({m.Price})");

    }
    mutexObj.ReleaseMutex();
    //sem.Release();

}

void TasksRrint()
{
    for(int i = 1; i <= 4; i++)
    {
        Task task = Task.Run(async () => await Print());
        task.Wait();
    }
}

void TasksInsert()
{
    for (int i = 1; i <= 4; i++)
    {
        Task task = Task.Run(() => Insert());
        task.Wait();
    }
}

async Task ReadAsync()
{
    using (var ctx1 = new PharmacyContext(options))
    {
        var drugs = await (from d in ctx1.Drugs
                           orderby d.Price
                           select d).ToListAsync();
        foreach (var m in drugs)
        {
            Console.WriteLine($"{m.Name} - Price:({m.Price})");
        }
    }
}

async Task Print()
{
    Console.WriteLine("Начало метода PrintAsync");
    await Task.Run(() => ReadAsync());
    Console.WriteLine("Конец метода PrintAsync");
}