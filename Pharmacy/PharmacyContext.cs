using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pharmacy
{
    public class PharmacyContext : DbContext
    {
        public DbSet<Drug> Drugs { get; set; }//= null!;
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Reciept> Reciept { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Pharmacist> Pharmacist { get; set; }
        public DbSet<Pharmacy_m> Pharmacy { get; set; }
        public DbSet<DrugType> DrugType { get; set; }

        public IQueryable<Drug> DrugsPriceLess(decimal price) => FromExpression(() => DrugsPriceLess(price));

        public PharmacyContext()
        {

        }

        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
        {
            
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost;Database=Pharmacy;Integrated Security=true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DrugConfiguration());
            modelBuilder.ApplyConfiguration(new DrugTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PharmacistConfiguration());
            modelBuilder.ApplyConfiguration(new PharmacyConfiguration());
            modelBuilder.ApplyConfiguration(new RecieptConfiguration());

            modelBuilder.Entity<Customer>().ToTable(t=>t.HasCheckConstraint("Age", "Age > 0 AND Age < 80"));
            modelBuilder.Entity<Pharmacist>().ToTable(t => t.HasCheckConstraint("Age", "Age > 0 AND Age < 80"));
            modelBuilder.HasDbFunction(() => DrugsPriceLess(default));

            //modelBuilder.Entity<Customer>().HasCheckConstraint("Age", "Age > 0 AND Age < 80");/////////////
            //modelBuilder.Entity<Pharmacist>().HasCheckConstraint("Age", "Age > 0 AND Age < 80");///////////
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Customer_id");
            builder.Property(p => p.fName).HasColumnName("First_name");
            builder.Property(p => p.fName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.lName).HasColumnName("Last_name");
            builder.Property(p => p.lName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(30);
            builder.Property(p => p.Phone).HasMaxLength(13);

            builder.HasData(new List<Customer>
            {
                new Customer() { Id = 1, fName = "Andrew", lName = "Oliynik", Age= 19, Email = "AndOl@gmail.com", Gender = true, Phone = "+380993702050"},
                new Customer() { Id = 2, fName = "Oleksii", lName = "Ostapchenko", Age= 19, Email = "OlOst@gmail.com", Gender = true, Phone = "+380993702051"},
                new Customer() { Id = 3, fName = "Ariana", lName = "Shamsha", Age= 19, Email = "ArSh@gmail.com", Gender = false, Phone = "+380993702052"},
                new Customer() { Id = 4, fName = "Oleg", lName = "Bilyk", Age= 19, Email = "OlBil@gmail.com", Gender = true, Phone = "+380993702053"},
            });

        }
    }

    public class DrugConfiguration : IEntityTypeConfiguration<Drug>
    {
        public void Configure(EntityTypeBuilder<Drug> builder)
        {
            builder.ToTable("Drugs").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Drug_id");
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(20);
            

            builder.HasData(new List<Drug>
            {
                new Drug() { Id = 1, Name = "Візин", Price = 20, Type = "Краплі", ManufacturerId = 1 },
                new Drug() { Id = 2, Name = "Синупрет", Price = 75, Type = "Настоянка", ManufacturerId = 2},
                new Drug() { Id = 3, Name = "Колдрекс", Price = 40, Type = "Розчинний порошок", ManufacturerId = 3},
                
            });

        }
    }

    public class DrugTypeConfiguration : IEntityTypeConfiguration<DrugType>
    {
        public void Configure(EntityTypeBuilder<DrugType> builder)
        {
            builder.ToTable("DrugTypes").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("DrugType_id");
            builder.Property(p => p.Amount).IsRequired();

            builder.HasData(new List<DrugType>
            {
                new DrugType() { Id = 1, Amount = 1, DrugId = 1, Pharmacy_mId = 1},
                new DrugType() { Id = 2, Amount = 1, DrugId = 2, Pharmacy_mId = 2},
                new DrugType() { Id = 3, Amount = 4, DrugId = 3, Pharmacy_mId = 3},
            });

        }
    }

    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable("Manufacturers").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Manufacturer_id");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.License).IsRequired();

            builder.HasData(new List<Manufacturer>
            {
                new Manufacturer() { Id = 1, Name = "Yassen", Address = "Balzaka, 15"},
                new Manufacturer() { Id = 2, Name = "Bionorica", Address = "Balzaka, 16"},
                new Manufacturer() { Id = 3, Name = "Coldrex", Address = "Balzaka, 17"},
            });

        }
    }

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Order_id");
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Created).IsRequired();

            builder.HasData(new List<Order>
            {
                new Order{ Id = 1, Amount = 1, Created = new DateTime(2022,11,22), DrugId = 1, PharmacistId = 1 },
                new Order{ Id = 2, Amount = 3, Created = new DateTime(2022,11,20) , DrugId = 2, PharmacistId = 2 },
                new Order{ Id = 3, Amount = 2, Created = new DateTime(2022,11,21) , DrugId = 3, PharmacistId = 3 },
            });

        }
    }

    public class PharmacistConfiguration : IEntityTypeConfiguration<Pharmacist>
    {
        public void Configure(EntityTypeBuilder<Pharmacist> builder)
        {
            builder.ToTable("Pharmacists").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Pharmacist_id");
            builder.Property(p => p.fName).HasColumnName("First_name");
            builder.Property(p => p.fName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.lName).HasColumnName("Last_name");
            builder.Property(p => p.lName).IsRequired().HasMaxLength(15);
            builder.Property(p => p.Password).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(13);
            builder.Property(p => p.Email).IsRequired();

            builder.HasData(new List<Pharmacist>
            {
                new Pharmacist{ Id = 1, fName = "Olexander", lName = "Marchenko", Age = 20, Email = "W1@gmail.com", Gender = true, Password = "123451", Phone = "+380959873454", PharmacyId = 3},
                new Pharmacist{ Id = 2, fName = "Valerii", lName = "Grozny", Age = 23, Email = "W2@gmail.com", Gender = true, Password = "123452", Phone = "+380959873454", PharmacyId = 2 },
                new Pharmacist{ Id = 3, fName = "Olexiy", lName = "Pavlenko", Age = 30, Email = "W3@gmail.com", Gender = true, Password = "123453", Phone = "+380959873454" , PharmacyId = 1},
            });

        }
    }

    public class PharmacyConfiguration : IEntityTypeConfiguration<Pharmacy_m>
    {
        public void Configure(EntityTypeBuilder<Pharmacy_m> builder)
        {
            builder.ToTable("Pharmacies").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Pharmacy_id");
            builder.Property(p => p.Address).IsRequired();

            builder.HasData(new List<Pharmacy_m>
            {
                new Pharmacy_m{ Id = 1, Address = "Bandery, 4"},
                new Pharmacy_m{ Id = 2, Address = "Bandery, 5"},
                new Pharmacy_m{ Id = 3, Address = "Bandery, 6"},
            });

        }
    }

    public class RecieptConfiguration : IEntityTypeConfiguration<Reciept>
    {
        public void Configure(EntityTypeBuilder<Reciept> builder)
        {
            builder.ToTable("Reciepts").Property(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Reciept_id");
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Created).IsRequired();

            builder.HasData(new List<Reciept>
            {
                new Reciept{ Id = 1, Amount = 3, Created = new DateTime(2022,11,10), CustomerId = 1, DrugId = 3},
                new Reciept{ Id = 2, Amount = 1, Created = new DateTime(2022,11,14), CustomerId = 2, DrugId = 1},
                new Reciept{ Id = 3, Amount = 1, Created = new DateTime(2022,11,12), CustomerId = 3, DrugId = 2},
            });

        }
    }

}
