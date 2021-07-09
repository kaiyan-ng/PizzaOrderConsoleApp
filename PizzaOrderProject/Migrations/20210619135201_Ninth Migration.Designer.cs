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
    [Migration("20210619135201_Ninth Migration")]
    partial class NinthMigration
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

                    b.HasData(
                        new
                        {
                            Id = 15,
                            Address = "23 Jalan Lokam, Singapore",
                            Date_Of_Birth = new DateTime(1988, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email_Address = "captainlevi@titanmail.com",
                            First_Name = "Darryl",
                            Gender = "Male",
                            Last_Name = "Chia",
                            Phone_Number = "94433168",
                            User_Id = 31,
                            Zip_Code = "537869"
                        },
                        new
                        {
                            Id = 20,
                            Address = "25, Tannery Lane #01-27",
                            Date_Of_Birth = new DateTime(1972, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email_Address = "johndoe@email.com",
                            First_Name = "John",
                            Gender = "Male",
                            Last_Name = "Doe",
                            Phone_Number = "94825335",
                            User_Id = 36,
                            Zip_Code = "347786"
                        },
                        new
                        {
                            Id = 12,
                            Address = "71 Jalan Jaskolski Hill",
                            Date_Of_Birth = new DateTime(1942, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email_Address = "reynolds.loma@hotmail.com",
                            First_Name = "Izhar Izuddin",
                            Gender = "Male",
                            Last_Name = "Raihan Nazir",
                            Phone_Number = "97627137",
                            User_Id = 28,
                            Zip_Code = "927511"
                        });
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

                    b.HasData(
                        new
                        {
                            Order_Id = 25,
                            Crust_Id = 2,
                            Customer_Id = 15,
                            Order_Date_And_Time = new DateTime(2021, 6, 19, 21, 52, 0, 533, DateTimeKind.Local).AddTicks(352),
                            Order_Status = "Order Completed",
                            Pizza_Id = 1,
                            Topping_Id = 6,
                            Topping_Id2 = 2,
                            Total_Amount = 28f
                        },
                        new
                        {
                            Order_Id = 27,
                            Crust_Id = 3,
                            Customer_Id = 20,
                            Order_Date_And_Time = new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2964),
                            Order_Status = "Order Completed",
                            Pizza_Id = 2,
                            Topping_Id = 8,
                            Topping_Id2 = 8,
                            Total_Amount = 32f
                        },
                        new
                        {
                            Order_Id = 30,
                            Crust_Id = 1,
                            Customer_Id = 18,
                            Order_Date_And_Time = new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2984),
                            Order_Status = "Order Completed",
                            Pizza_Id = 5,
                            Topping_Id = 1,
                            Topping_Id2 = 4,
                            Total_Amount = 25f
                        },
                        new
                        {
                            Order_Id = 31,
                            Crust_Id = 2,
                            Customer_Id = 12,
                            Order_Date_And_Time = new DateTime(2021, 6, 19, 21, 52, 0, 534, DateTimeKind.Local).AddTicks(2987),
                            Order_Status = "Order Completed",
                            Pizza_Id = 1,
                            Topping_Id = 6,
                            Topping_Id2 = 1,
                            Total_Amount = 28f
                        });
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
                        },
                        new
                        {
                            Id = 8,
                            Name = "None",
                            Price = 0f
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

                    b.HasData(
                        new
                        {
                            Id = 31,
                            Password = "beybladeslash2512",
                            Username = "levivsmonketbc"
                        },
                        new
                        {
                            Id = 36,
                            Password = "Password",
                            Username = "JohnDoe"
                        },
                        new
                        {
                            Id = 28,
                            Password = "b4a9574d",
                            Username = "izhazir"
                        });
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
