using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IMS.Models;

namespace IMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<IMS.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<IMS.Models.Bill> Bill { get; set; }

        public DbSet<IMS.Models.BillType> BillType { get; set; }

        public DbSet<IMS.Models.Branch> Branch { get; set; }

        public DbSet<IMS.Models.CashBank> CashBank { get; set; }

        public DbSet<IMS.Models.Currency> Currency { get; set; }

        public DbSet<IMS.Models.Customer> Customer { get; set; }

        public DbSet<IMS.Models.CustomerType> CustomerType { get; set; }

        public DbSet<IMS.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<IMS.Models.Invoice> Invoice { get; set; }

        public DbSet<IMS.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<IMS.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<IMS.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<IMS.Models.PaymentType> PaymentType { get; set; }

        public DbSet<IMS.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<IMS.Models.Product> Product { get; set; }

        public DbSet<IMS.Models.ProductType> ProductType { get; set; }

        public DbSet<IMS.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<IMS.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<IMS.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<IMS.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<IMS.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<IMS.Models.SalesType> SalesType { get; set; }

        public DbSet<IMS.Models.Shipment> Shipment { get; set; }

        public DbSet<IMS.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<IMS.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<IMS.Models.Vendor> Vendor { get; set; }

        public DbSet<IMS.Models.VendorType> VendorType { get; set; }

        public DbSet<IMS.Models.Warehouse> Warehouse { get; set; }

        public DbSet<IMS.Models.UserProfile> UserProfile { get; set; }
    }
}
