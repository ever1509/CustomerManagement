using CustomerManagement.WebUI.Models.Data.Configurations;
using CustomerManagement.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Data
{
    public class CustomerManagementDbContext :DbContext
    {
        public CustomerManagementDbContext(DbContextOptions<CustomerManagementDbContext> options)
            :base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerOrderConfiguration());

        }
    }
}
