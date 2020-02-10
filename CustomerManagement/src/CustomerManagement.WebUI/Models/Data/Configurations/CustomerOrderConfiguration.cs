using CustomerManagement.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Data.Configurations
{
    public class CustomerOrderConfiguration : IEntityTypeConfiguration<CustomerOrder>
    {
        public void Configure(EntityTypeBuilder<CustomerOrder> builder)
        {
            builder.HasKey(e => e.CustomerOrderId);
            builder.Property(e => e.OrderCreated).HasColumnType("datetime");

            builder.HasOne(e => e.Customer)
                .WithMany(d => d.CustomerOrders)
                .HasForeignKey(e => e.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Customer_CustomerOrders");

            builder.HasOne(e => e.Product)
                .WithMany(d => d.CustomerOrders)
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Product_CustomerOrder");
        }
    }
}
