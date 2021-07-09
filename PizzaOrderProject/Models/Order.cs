using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderProject.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        public DateTime Order_Date_And_Time { get; set; }
        public string Order_Status { get; set; }
        public int Customer_Id { get; set; }
        public int Pizza_Id { get; set; }
        public int Topping_Id { get; set; }
        public int Topping_Id2 { get; set; }
        public int Crust_Id { get; set; }

        [ForeignKey("Pizza_Id")]
        public Pizza Pizza { get; set; }

        [ForeignKey("Topping_Id")]
        public Topping Topping { get; set; }

        [ForeignKey("Crust_Id")]
        public Crust Crust
        {
            get; set;
        }

        public float Total_Amount { get; set; }

        [ForeignKey("Customer_Id")]
        public Customer Customer { get; set; }

        


    }
}
