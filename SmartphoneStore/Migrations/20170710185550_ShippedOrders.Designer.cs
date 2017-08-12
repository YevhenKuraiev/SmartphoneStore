using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SmartphoneStore.DAL.EF_Core;

namespace SmartphoneStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170710185550_ShippedOrders")]
    partial class ShippedOrders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartphoneStore.DAL.Entities.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderID");

                    b.Property<int?>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("SmartphoneStore.DAL.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<bool>("GiftWrap");

                    b.Property<string>("Name");

                    b.Property<bool>("Shipped");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SmartphoneStore.DAL.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SmartphoneStore.DAL.Entities.CartLine", b =>
                {
                    b.HasOne("SmartphoneStore.DAL.Entities.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("SmartphoneStore.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });
        }
    }
}
