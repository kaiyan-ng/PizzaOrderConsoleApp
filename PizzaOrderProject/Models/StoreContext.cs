using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaOrderProject.Models
{
    public class StoreContext:DbContext
    {
        readonly string connectionString = @"Data source=LAPTOP-5NP5HKN8\SQLEXPRESS;Integrated security = true; Initial Catalog =dbPizzaOrderApp";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Crust> Crust { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                Id = 1,
                Name = "Hawaiian",
                Price = 23.00f
            }) ;

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 28.00f
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                Id = 3,
                Name = "Margherita",
                Price = 25.00f
            });
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                Id = 4,
                Name = "Meat Galore",
                Price = 26.00f
            });
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                Id = 5,
                Name = "Veggie Lover",
                Price = 22.00f
            });
            modelBuilder.Entity<Crust>().HasData(new Crust
            {
                Id = 1,
                Name = "Thin",
                Price = 1.00f
            });
            modelBuilder.Entity<Crust>().HasData(new Crust
            {
                Id = 2,
                Name = "Thick",
                Price = 2.00f
            });
            modelBuilder.Entity<Crust>().HasData(new Crust
            {
                Id = 3,
                Name = "Stuffed",
                Price = 4.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 1,
                Name = "Olives",
                Price = 1.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 2,
                Name = "Tomatoes",
                Price = 1.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 3,
                Name = "Onions",
                Price = 1.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 4,
                Name = "Bell Peppers",
                Price = 1.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 5,
                Name = "Mushrooms",
                Price = 1.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 6,
                Name = "Chicken Sausages",
                Price = 2.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 7,
                Name = "Ham",
                Price = 2.00f
            });
            modelBuilder.Entity<Topping>().HasData(new Topping
            {
                Id = 8,
                Name = "None",
                Price = 0.00f
            });

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id=15,
                    User_Id=31,
                    First_Name="Darryl",
                    Last_Name = "Chia",
                    Gender = "Male",
                    Date_Of_Birth = new DateTime(1988,06,24),
                    Address = "23 Jalan Lokam, Singapore",
                    Zip_Code = "537869",
                    Phone_Number = "94433168",
                    Email_Address = "captainlevi@titanmail.com"
                },

                new Customer
                {
                    Id = 20,
                    User_Id = 36,
                    First_Name = "John",
                    Last_Name = "Doe",
                    Gender = "Male",
                    Date_Of_Birth = new DateTime(1972,10,03),
                    Phone_Number = "94825335",
                    Address = "25, Tannery Lane #01-27",
                    Zip_Code = "347786",
                    Email_Address = "johndoe@email.com"
                },
                 new Customer
                 {
                     Id = 12,
                     User_Id = 28,
                     First_Name = "Izhar Izuddin",
                     Last_Name = "Raihan Nazir",
                     Gender = "Male",
                     Date_Of_Birth = new DateTime(1942, 03, 04),
                     Phone_Number = "97627137",
                     Address = "71 Jalan Jaskolski Hill",
                     Zip_Code = "927511",
                     Email_Address = "reynolds.loma@hotmail.com"
                 }
                );

            modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = 31,
                    Username = "levivsmonketbc",
                    Password = "beybladeslash2512"

                }, 
                new User
                {
                    Id =36,
                    Username = "JohnDoe",
                    Password = "Password"
                },
                new User
                {
                    Id = 28,
                    Username = "izhazir",
                    Password = "b4a9574d"

                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Order_Id = 25,
                    Order_Date_And_Time = DateTime.Now,
                    Order_Status = "Order Completed",
                    Customer_Id = 15,
                    Pizza_Id = 1,
                    Topping_Id = 6,
                    Topping_Id2 = 2,
                    Crust_Id = 2,
                    Total_Amount = 28,
                },

                 new Order
                 {
                     Order_Id = 27,
                     Order_Date_And_Time = DateTime.Now,
                     Order_Status = "Order Completed",
                     Customer_Id = 20,
                     Pizza_Id = 2,
                     Topping_Id = 8,
                     Topping_Id2 = 8,
                     Crust_Id = 3,
                     Total_Amount = 32,
                 },

                 new Order
                 {
                     Order_Id = 30,
                     Order_Date_And_Time = DateTime.Now,
                     Order_Status = "Order Completed",
                     Customer_Id = 18,
                     Pizza_Id = 5,
                     Topping_Id = 1,
                     Topping_Id2 = 4,
                     Crust_Id = 1,
                     Total_Amount = 25,
                 },
                 new Order
                 {
                     Order_Id = 31,
                     Order_Date_And_Time = DateTime.Now,
                     Order_Status = "Order Completed",
                     Customer_Id = 12,
                     Pizza_Id = 1,
                     Topping_Id = 6,
                     Topping_Id2 = 1,
                     Crust_Id = 2,
                     Total_Amount = 28,
                 }

            ) ;

        }

    }
}
