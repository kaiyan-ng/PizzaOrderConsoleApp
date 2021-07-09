using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public int User_Id { get; set; }

        [Required(ErrorMessage = "Your first name is required")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Your last name is required")]
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public DateTime Date_Of_Birth { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        public string Phone_Number { get; set; }

        [Required(ErrorMessage = "Delivery Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Zip code is required")]
        public string Zip_Code { get; set; }

        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        public string Email_Address { get; set; }

        [ForeignKey("User_Id")]
        public User User { get; set; }

    }
}
