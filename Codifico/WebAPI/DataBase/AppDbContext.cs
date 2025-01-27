using Codifico.WebAPI.Objects.BaseClass;
using Codifico.WebAPI.Objects.Extends;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;

namespace Codifico.WebAPI.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Shippers> Shippers { get; set; }

        /* Objetos para vistas */
        public DbSet<OrdersPrediction> OrdersPredictions { get; set; }
        public DbSet<OrdersView> OrdersView { get; set; }

        public DbSet<EmployeeDropDown> EmployeeDropdown { get; set; }
        public DbSet<ShipperDropDown> ShipperDropdown { get; set; }
        public DbSet<ProductDropDown> ProductDropdown { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder = AddTables(modelBuilder);
            modelBuilder = AddPrimaryKeys(modelBuilder);
            modelBuilder = AddForeignKeys(modelBuilder);
            modelBuilder = AddEntidadesSinPrimaryKey(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder AddEntidadesSinPrimaryKey(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdersPrediction>()
                 .HasNoKey();

            modelBuilder.Entity<OrdersView>()
             .HasNoKey();

            modelBuilder.Entity<ProductDropDown>()
             .HasNoKey();

            modelBuilder.Entity<ShipperDropDown>()
                .HasNoKey();

            modelBuilder.Entity<EmployeeDropDown>()
         .HasNoKey();


            return modelBuilder;
        }

        private ModelBuilder AddTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .ToTable("Employees", "HR");

            modelBuilder.Entity<Categories>()
                .ToTable("Categories", "Production");

            modelBuilder.Entity<Products>()
                .ToTable("Products", "Production");

            modelBuilder.Entity<Suppliers>()
                .ToTable("Suppliers", "Production");

            modelBuilder.Entity<Customers>()
                .ToTable("Customers", "Sales");

            modelBuilder.Entity<Orders>()
                .ToTable("Orders", "Sales");

            modelBuilder.Entity<OrderDetails>()
                .ToTable("OrderDetails", "Sales");

            modelBuilder.Entity<Shippers>()
                .ToTable("Shippers", "Sales");

            return modelBuilder;
        }


        private ModelBuilder AddPrimaryKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
             .HasKey(emp => new { emp.empid });

            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => new { od.orderid, od.productid });

            return modelBuilder;
        }


        private ModelBuilder AddForeignKeys(ModelBuilder modelBuilder)
        {
            return modelBuilder;
        }


    }
}
