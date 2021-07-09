using PizzaOrderProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderProject.Services
{
    public class UserService
    {

        readonly StoreContext context;

        public UserService()
        {
            context = new StoreContext();
        }

        public bool UserLogin(User user)
        {
            try
            {
                User myUser = context.Users.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (myUser != null)
                {
                    return true;
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Username and password is required.");
                return false;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("User not found. Incorrect username or password. ");
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid username or password.");
            }
            return false;

        }

        public bool CheckUsername(User user)
        {
            try
            {
                User newUser = context.Users.Single(u => u.Username == user.Username);
                if (newUser != null)
                {
                    return true;
                }
            } catch (Exception)
            {
                return false;
            }

            return false;

        }

        /// <summary>
        /// Insert data into user table
        /// </summary>
        /// <param name="user">User object which contains user login details</param>
        /// <returns></returns>
        public bool UserSignUp(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }

        public int GetUserId(User user)
        {
            User myUser = context.Users.Single(u => u.Username == user.Username && u.Password == user.Password);
            return myUser.Id;
        }
        
       
        /// <summary>
        /// Insert Customer data into Customer table
        /// </summary>
        /// <param name="customer"> Customer object which contains customer's personal particulars</param>
        /// <returns></returns>
        public int AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer.Id;
        }

        public int GetCustomerId(int userId)
        {
            Customer myCustomer = context.Customers.Where(c => c.User_Id == userId).FirstOrDefault();
            return myCustomer.Id;
        }

        public Customer GetCustomer(int id)
        {
            Customer myCustomer = context.Customers.Where(c => c.Id == id).FirstOrDefault();
            return myCustomer;
        }

        public string GetCustomerAdd(int customerId)
        {
            Customer myCustomer = context.Customers.Where(u => u.Id == customerId).FirstOrDefault();
            return myCustomer.Address;
        }


    }
}
