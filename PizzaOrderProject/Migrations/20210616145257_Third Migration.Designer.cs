﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaOrderProject.Models;

namespace PizzaOrderProject.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210616145257_Third Migration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaOrderProject.Models.Crust", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Crust");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Thin",
                            Price = 1f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Thick",
                            Price = 2f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Stuffed",
                            Price = 4f
                        });
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("Zip_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Order", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Crust_Id")
                        .HasColumnType("int");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_Date_And_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pizza_Id")
                        .HasColumnType("int");

                    b.Property<int>("Topping_Id")
                        .HasColumnType("int");

                    b.Property<int>("Topping_Id2")
                        .HasColumnType("int");

                    b.Property<float>("Total_Amount")
                        .HasColumnType("real");

                    b.HasKey("Order_Id");

                    b.HasIndex("Crust_Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("Pizza_Id");

                    b.HasIndex("Topping_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hawaiian",
                            Price = 23f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pepperoni",
                            Price = 28f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Margherita",
                            Price = 25f
                        },
                        new
                        {
                            Id = 4,
                            Name = "Meat Galore",
                            Price = 26f
                        },
                        new
                        {
                            Id = 5,
                            Name = "Veggie Lover",
                            Price = 22f
                        });
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Olives",
                            Price = 1f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tomatoes",
                            Price = 1f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Onions",
                            Price = 1f
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bell Peppers",
                            Price = 1f
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mushrooms",
                            Price = 1f
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chicken Sausages",
                            Price = 2f
                        },
                        new
                        {
                            Id = 7,
                            Name = "Ham",
                            Price = 2f
                        });
                });

            modelBuilder.Entity("PizzaOrderProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Customer", b =>
                {
                    b.HasOne("PizzaOrderProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PizzaOrderProject.Models.Order", b =>
                {
                    b.HasOne("PizzaOrderProject.Models.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("Crust_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaOrderProject.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaOrderProject.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("Pizza_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaOrderProject.Models.Topping", "Topping")
                        .WithMany()
                        .HasForeignKey("Topping_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crust");

                    b.Navigation("Customer");

                    b.Navigation("Pizza");

                    b.Navigation("Topping");
                });
#pragma warning restore 612, 618
        }
    }
}
