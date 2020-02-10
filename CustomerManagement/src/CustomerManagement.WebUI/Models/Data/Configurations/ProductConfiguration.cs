using CustomerManagement.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductId);
            builder.Property(e => e.ProductName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.ProductCreated).HasColumnType("datetime").IsRequired(false);
            builder.Property(e => e.Description).HasColumnType("varchar(200)").IsRequired();
            builder.Property(e => e.Stock).HasColumnType("int");
            


        }
    }
}
