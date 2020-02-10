using CustomerManagement.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.CustomerId);
            builder.Property(e => e.CustomerName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.CustomerLastName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(e => e.CustomerPhone).HasColumnType("varchar(10)").IsRequired();
            builder.Property(e => e.CustomerEmail).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.CustomerCreated).HasColumnType("datetime").IsRequired(false);

        }
    }
}
