namespace CodeFirst_BillingProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class BillingContext : DbContext
    {
        // Your context has been configured to use a 'BillingContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_BillingProject.BillingContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BillingContext' 
        // connection string in the application configuration file.
        public BillingContext()
            : base("name=Connection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual  DbSet<County> Counties { get; set; }

        public virtual DbSet<Unit> Units { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<InvoiceHeader> InvoiceHeaders { get; set; }

        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class City
    {
        public City()
        {
            this.Counties = new HashSet<County>();
        }
        public int CityID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<County> Counties { get; set; }

    }

    public class County
    {
        public County()
        {
            this.Customers = new HashSet<Customer>();
        }
        public int CountyID { get; set; }
        public string Description { get; set; }

        public int CityID { get; set; }
        public virtual City city { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
       

    }

    public class Unit
    {
        public Unit()
        {
            this.Products = new HashSet<Product>();
        }
        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public class Customer
    {
        public Customer()
        {
            this.InvoiceHeaders = new HashSet<InvoiceHeader>();
        }
       
        [Key]
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }

        public string CustomerAddress { get; set; }

        public virtual County county { get; set; }
        public int CountyID { get; set; }

        public virtual ICollection<InvoiceHeader> InvoiceHeaders { get; set; }

    }

    public class Product
    {
        public Product()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int ProductNumber { get; set; }


        public int UnitPrice { get; set; }
        public int UnitID { get; set; }
        public virtual Unit unit { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


    }

    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }
        [Key]
        public int InvoiceID { get; set; }
       
       

        public DateTime InvoiceDateTime { get; set; }

        
        public int DeliveryNoteNumber { get; set; }

        public DateTime PaymentDateTime { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer customer { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

      

    }

    public class InvoiceDetail
    {
        [Key, Column(Order = 0)]
        public int InvoiceID { get; set; }
        [Key, Column(Order = 1)]
        public int ProductID { get; set; }
         
        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public int TotalAmount { get; set; }

        public decimal ValueAddedTextAmount { get; set; }

        public decimal TotalAmountwithVAT { get; set; }

        public string Description { get; set; }

        public virtual Product product { get; set; }

        public virtual InvoiceHeader invoiceHeader { get; set; }
    }





}