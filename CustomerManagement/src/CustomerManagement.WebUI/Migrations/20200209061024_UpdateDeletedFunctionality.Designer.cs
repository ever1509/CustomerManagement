﻿// <auto-generated />
using System;
using CustomerManagement.WebUI.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerManagement.WebUI.Migrations
{
    [DbContext(typeof(CustomerManagementDbContext))]
    [Migration("20200209061024_UpdateDeletedFunctionality")]
    partial class UpdateDeletedFunctionality
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerManagement.WebUI.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CustomerCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("CustomerStatus")
                        .HasColumnType("bit");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CustomerManagement.WebUI.Models.Entities.CustomerOrder", b =>
                {
                    b.Property<int>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderCreated")
                        .HasColumnType("datetime");

                    b.Property<bool>("OrderStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CustomerOrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("CustomerManagement.WebUI.Models.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("ProductCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CustomerManagement.WebUI.Models.Entities.CustomerOrder", b =>
                {
                    b.HasOne("CustomerManagement.WebUI.Models.Entities.Customer", "Customer")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_CustomerOrders")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerManagement.WebUI.Models.Entities.Product", "Product")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_CustomerOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
