using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderProject.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public float Price { get; set; } 

    }
}
