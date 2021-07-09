using PizzaOrderProject.Services;
using System;
using PizzaOrderProject.Models;
using System.Collections.Generic;

namespace PizzaOrderProject
{
    class Program
    {
        UserService userService = new UserService();
        ManageOrder manageOrder = new ManageOrder();
        bool loginSuccess = false;
        bool isSignUp = false;

        public Program()
        {
        }

        /// <summary>
        /// Takes login details from user.
        /// </summary>
        /// <returns></returns>
        private User TakeUserDetails()
        {
            User user = new User();
            user.Password = " ";
            Console.WriteLine("Please enter your username.");
            user.Username = Console.ReadLine();
            if (isSignUp == true && userService.CheckUsername(user) == true)
            {
                while (userService.CheckUsername(user) == true)
                {
                    Console.WriteLine("Username is already taken." +
                    "\nPlease use a different username.");
                    Console.WriteLine("Please enter your username.");
                    user.Username = Console.ReadLine();
                }
            }
            Console.WriteLine("Please enter your password.");
            user.Password = Console.ReadLine();
            return user;

        }

        /// <summary>
        /// Verify if user exists and retrieves existing user's customer id
        /// </summary>
        private int UserCheck()
        {
            User myUser = TakeUserDetails();
            int customerId = 0;
            
            if (userService.UserLogin(myUser) == true)
            {
                int userId = userService.GetUserId(myUser);
                loginSuccess = true;
                customerId = userService.GetCustomerId(userId);
            }

            return customerId;
        }


        /// <summary>
        /// Registering new user, takes new user's personal details
        /// </summary>
        /// <returns></returns>
        private Customer TakeCustomerDetails(int userId)
        {
            Console.WriteLine("                 REGISTRATION                   ");
            Console.WriteLine("------------------------------------------------");
            Customer customer = new Customer();
        
            Console.WriteLine("Please enter your first name.");
            customer.First_Name = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            customer.Last_Name = Console.ReadLine();
            
            bool isGender = false;
            while (isGender == false)
            {
                Console.WriteLine("Please enter your gender. Male/Female");
                string gender = Console.ReadLine();
                if (gender == "Male" || gender == "male" || gender == "Female" || gender == "female")
                {
                    customer.Gender = gender;
                    isGender = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter 'Male' or 'Female'.");
                }
           
            }
            Console.WriteLine("Please enter your date of birth (YYYY-MM-DD)");
            DateTime tempDate;
            while (!DateTime.TryParse(Console.ReadLine(), out tempDate)){
                Console.WriteLine("Invalid date of birth entered.");
                Console.WriteLine("Please enter your date of birth in the format: YYYY-MM-DD");
            }
            customer.Date_Of_Birth = tempDate;

            //Phone number validation
            string Phone = "";
            bool phoneValidation = false;
            while (phoneValidation == false)
            {
                Console.WriteLine("Please enter your phone number");
                Phone = Console.ReadLine();
                if (Int32.TryParse(Phone, out int phone))
                {
                    if (Phone.Length == 8)
                    {
                        int firstDigit = phone / 10000000;

                        if (firstDigit == 6 || firstDigit == 8 || firstDigit == 9)
                        {
                            phoneValidation = true;
                            customer.Phone_Number = Phone;

                        }
                        else
                        {
                            Console.WriteLine("Invalid phone number.");
                        }

                    }else
                    {
                        Console.WriteLine("Invalid phone number. " +
                        "\nPlease enter your 8-digit phone number.");
                    }

                } else
                {
                    Console.WriteLine("Invalid phone number. " +
                        "\nPlease enter your 8-digit phone number.");
                }
            }

            Console.WriteLine("Please enter your delivery address.");
            customer.Address = Console.ReadLine();

            bool isZipCode = false;
            while (isZipCode == false)
            {
                Console.WriteLine("Please enter your zip code.");
                string zipCode = Console.ReadLine();
                if (zipCode.Length == 6)
                {
                    if (Int32.TryParse(zipCode, out int zipCodeNum) == false)
                    {
                        Console.WriteLine("Invalid zip code." +
                             "\nPlease enter a 6-digit zip code.");
                    } else
                    {
                        isZipCode = true;
                        customer.Zip_Code = zipCode;
                    }

                }else
                {
                    Console.WriteLine("Invalid zip code." +
                            "\nPlease enter a 6-digit zip code."); 
                }
            }

            Console.WriteLine("Please enter your e-mail address.");
            customer.Email_Address = Console.ReadLine();
            customer.User_Id = userId;
            return customer;
        }


        /// <summary>
        /// Adds new user details and retrieves new customer id
        /// </summary>
        /// <returns> customer id </returns>
        private int CreateNewUser()
        {
            int customerId = 0;
            isSignUp = true;

            User newUser = TakeUserDetails();
            if (userService.UserSignUp(newUser) == true)
            {
                int userId = userService.GetUserId(newUser);
                loginSuccess = true;
                Customer newCustomer = TakeCustomerDetails(userId);
                customerId = userService.AddCustomer(newCustomer);
            }
            return customerId;
        }

        /// <summary>
        /// Displays types of pizza 
        /// </summary>
        public void PizzaMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                  PIZZA MENU                ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" No. Pizza                             Price");
            Console.WriteLine("                                            ");
            Console.WriteLine(" 1.  Hawaiian                         $23.00");
            Console.WriteLine(" 2.  Pepperoni                        $28.00");
            Console.WriteLine(" 3.  Margherita                       $25.00");
            Console.WriteLine(" 4.  Meat Galore                      $26.00");
            Console.WriteLine(" 5.  Veggie Lover                     $22.00");
            Console.WriteLine("--------------------------------------------");
        }

        /// <summary>
        /// Takes customer's choice of pizza
        /// </summary>
        /// <returns>Pizza id</returns>
        public int PizzaOrder()
        {
            PizzaMenu();
            Console.WriteLine("Please select your choice of pizza [1-5].");
            int pizzaType = 1;

            while (!Int32.TryParse(Console.ReadLine(),out pizzaType))
            {
                Console.WriteLine("Invalid pizza number entered. " +
                    "\nPlease enter your choice of pizza from 1-5.");
            }
            return pizzaType;
        }

        /// <summary>
        /// Displays choices of crust
        /// </summary>
        public void CrustMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("               CHOICE OF CRUST              ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" No. Crust                             Price");
            Console.WriteLine("                                            ");
            Console.WriteLine(" 1.  Thin                             +$1.00");
            Console.WriteLine(" 2.  Thick                            +$2.00");
            Console.WriteLine(" 3.  Stuffed                          +$4.00");
            Console.WriteLine("--------------------------------------------");
        }

        /// <summary>
        /// Takes customer's choice of crust 
        /// </summary>
        /// <returns>Crust id</returns>
        public int CrustOrder()
        {
            CrustMenu();
            Console.WriteLine("Please select your choice of crust [1-3].");
            int pizzaCrust = 1;
            while(!Int32.TryParse(Console.ReadLine(), out pizzaCrust))
            {
                Console.WriteLine("Invalid pizza crust number entered." +
                    "\n Please enter your choice of crust from 1-3.");
            }
            return pizzaCrust;
        }

        /// <summary>
        /// Displays choices of toppings
        /// </summary>
        public void ToppingMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("             CHOICE OF TOPPINGS             ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" No. Topping                           Price");
            Console.WriteLine("                                            ");
            Console.WriteLine(" 1.  Olives                           +$1.00");
            Console.WriteLine(" 2.  Tomatoes                         +$1.00");
            Console.WriteLine(" 3.  Onions                           +$1.00");
            Console.WriteLine(" 4.  Bell Peppers                     +$1.00");
            Console.WriteLine(" 5.  Mushrooms                        +$1.00");
            Console.WriteLine(" 6.  Chicken Sausages                 +$2.00");
            Console.WriteLine(" 7.  Ham                              +$2.00");
            Console.WriteLine(" 8.  None                             +$0.00");
            Console.WriteLine("--------------------------------------------");
        }

        /// <summary>
        /// Takes customer choice of first topping
        /// </summary>
        /// <returns> Topping id of the first topping </returns>
        public int FirstToppingOrder()
        {
            ToppingMenu();
            Console.WriteLine("Please choose your toppings. You may select up to two toppings." +
                "\nPlease select your first topping [1-8]");
            int pizzaTopOne = 1;
            while (!Int32.TryParse(Console.ReadLine(), out pizzaTopOne))
            {
                Console.WriteLine("Invalid topping number entered." +
                    "\n Please enter your choice of topping from 1-8.");
            }
            return pizzaTopOne;
        }

        /// <summary>
        /// Takes customer choice of second topping
        /// </summary>
        /// <returns> Topping id of the second topping </returns>
        public int SecToppingOrder()
        {
            Console.WriteLine("Please select your second topping [1-8].");
            int pizzaTopTwo = 1;
            while (!Int32.TryParse(Console.ReadLine(), out pizzaTopTwo))
            {
                Console.WriteLine("Invalid topping number entered." +
                    "\n Please enter your choice of topping from 1-8.");
            }
            return pizzaTopTwo;
        }


        /// <summary>
        /// Put together the order details
        /// </summary>
        /// <param name="pizzaId"> Pizza Id </param>
        /// <param name="crustId"> Crust Id </param>
        /// <param name="topIdOne"> Topping Id of first topping </param>
        /// <param name="topIdTwo">Topping Id of second topping </param>
        /// <param name="customerId"> Customer Id </param>
        /// <returns></returns>
        public Order CreateOrder(int pizzaId, int crustId, int topIdOne, int topIdTwo, int customerId)
        {
            Order order = new Order();
            order.Pizza_Id = pizzaId;
            order.Crust_Id = crustId;
            order.Topping_Id = topIdOne;
            order.Topping_Id2 = topIdTwo;
            order.Order_Date_And_Time = DateTime.Now;
            order.Customer_Id = customerId;
            order.Order_Status = "Pending Confirmation";
            order.Total_Amount = CalculateTotal(pizzaId, crustId, topIdOne, topIdTwo);
            return order;

        }

        /// <summary>
        /// Calculates the total bill
        /// </summary>
        /// <param name="pizzaId"> Pizza Id </param>
        /// <param name="crustId"> Crust Id </param>
        /// <param name="topIdOne"> Topping Id of first topping </param>
        /// <param name="topIdTwo">Topping Id of second topping </param>
        /// <returns></returns>
        public float CalculateTotal(int pizzaId, int crustId, int topIdOne, int topIdTwo)
        {
            ManageOrder manageOrder = new ManageOrder();
            float pizzaAmt = manageOrder.GetPizza(pizzaId).Price;
            float crustAmt = manageOrder.GetCrust(crustId).Price;
            float toppingAmtOne = manageOrder.GetTopping(topIdOne).Price;
            float toppingAmtTwo = manageOrder.GetTopping(topIdTwo).Price;
            float toppingAmt = toppingAmtOne + toppingAmtTwo;
            float total = pizzaAmt + crustAmt + toppingAmt;
            return total;
        }

        /// <summary>
        /// Retrieves order Id 
        /// </summary>
        /// <param name="pizzaId"></param>
        /// <param name="crustId"></param>
        /// <param name="topIdOne"></param>
        /// <param name="topIdTwo"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public int GetOrderId(int pizzaId, int crustId, int topIdOne, int topIdTwo, int customerId)
        {
            ManageOrder manageOrder = new ManageOrder();

            Order newOrder = CreateOrder(pizzaId, crustId, topIdOne, topIdTwo, customerId);
            int orderId = manageOrder.AddOrder(newOrder);
            return orderId;

        }

        /// <summary>
        /// Seeks confirmation from user on order details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Order ConfirmOrder(int id)
        {
            ManageOrder manageOrder = new ManageOrder();
            Order myOrder = manageOrder.GetOrder(id);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                ORDER DETAILS               ");
            Console.WriteLine("Order Id: " + myOrder.Order_Id);
            Console.WriteLine("Date and Time: " + myOrder.Order_Date_And_Time);
            Console.WriteLine("Order Status: " + myOrder.Order_Status);
            Console.WriteLine("Delivery Address: " + userService.GetCustomerAdd(myOrder.Customer_Id));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Pizza: "+manageOrder.GetPizza(myOrder.Pizza_Id).Name+"   $" + manageOrder.GetPizza(myOrder.Pizza_Id).Price);
            Console.WriteLine("Crust: "+manageOrder.GetCrust(myOrder.Crust_Id).Name+ "   $" + manageOrder.GetCrust(myOrder.Crust_Id).Price);
            Console.WriteLine("Toppings ");
            Console.WriteLine("Topping 1 " + manageOrder.GetTopping(myOrder.Topping_Id).Name + "   $" + manageOrder.GetTopping(myOrder.Topping_Id).Price);
            Console.WriteLine("Topping 2: " + manageOrder.GetTopping(myOrder.Topping_Id2).Name + "   $" + manageOrder.GetTopping(myOrder.Topping_Id2).Price);
            Console.WriteLine("Total Amount: $" + myOrder.Total_Amount);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                                             ");

            bool IsValid = false;
            do
            {
                Console.WriteLine("Please confirm your order. Yes/No");
                string input = Console.ReadLine();
                if(input == "Yes" || input == "yes")
                {
                    IsValid = true;
                    if (manageOrder.UpdateOrder(myOrder.Order_Id, 1) == true)
                    {
                        Console.WriteLine("Your order is confirmed.");
                        Console.WriteLine("Please pay $" + myOrder.Total_Amount + " cash on delivery. Thank you for your order!");
                        Console.WriteLine("Press enter to return to main menu.");
                        Console.ReadKey();

                    }
                }
                else if (input == "No" || input == "no")
                {
                    IsValid = true;
                    if (manageOrder.UpdateOrder(myOrder.Order_Id, 2) == true)
                    {
                        Console.WriteLine("Your order is successfully cancelled.");
                        Console.WriteLine("Press enter to return to main menu.");
                        Console.ReadKey();

                    }

                } else
                {
                    Console.WriteLine("Invalid Entry. " +
                        "\nPlease enter 'Yes' to confirm your order or 'No' to cancel your order.");
                }

            } while (IsValid == false);

            return myOrder;

        }


        /// <summary>
        /// Displays the main menu of the console application
        /// </summary>
        void MainMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("       Pizza Application Menu               ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("      1. Make an order");
            Console.WriteLine("      2. View orders");
            Console.WriteLine("      3. Cancel an order");
            Console.WriteLine("      4. Exit application");
            Console.WriteLine("-------------------------------------");
        }


        /// <summary>
        /// Displays order details/receipt
        /// </summary>
        /// <param name="customerId"></param>
        void PrintOrders(int customerId)
        {
            List<Order> orders = manageOrder.GetAllOrders(customerId);
            foreach (var item in orders)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("                ORDER DETAILS               ");
                Console.WriteLine("Order Id: " + item.Order_Id);
                Console.WriteLine("Date and Time: " + item.Order_Date_And_Time);
                Console.WriteLine("Order Status: " + item.Order_Status);
                Console.WriteLine("Delivery Address: " + userService.GetCustomerAdd(item.Customer_Id));
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Pizza: " + manageOrder.GetPizza(item.Pizza_Id).Name + "   $" + manageOrder.GetPizza(item.Pizza_Id).Price);
                Console.WriteLine("Crust: " + manageOrder.GetCrust(item.Crust_Id).Name + "   +$" + manageOrder.GetCrust(item.Crust_Id).Price);
                Console.WriteLine("Toppings ");
                Console.WriteLine("Topping 1 " + manageOrder.GetTopping(item.Topping_Id).Name + "   +$" + manageOrder.GetTopping(item.Topping_Id).Price);
                Console.WriteLine("Topping 2: " + manageOrder.GetTopping(item.Topping_Id2).Name + "   +$" + manageOrder.GetTopping(item.Topping_Id2).Price);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Total Amount: $" + item.Total_Amount);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("                                             ");
            }

        }
       
        static void Main(string[] args)
        {
            Program program = new Program();
            ManageOrder manageOrder = new ManageOrder();
            Order newOrder = new Order();
            int pizzaId = 0;
            int crustId = 0;
            int topIdOne = 8;
            int topIdTwo = 8;
            int customerId = 0;

            bool validEntry = false;
            do
            {

                Console.WriteLine("Welcome! ");
                Console.WriteLine("Are you an existing user? Yes/No");
                string resp = Console.ReadLine();
                if (resp == "Yes" || resp == "yes")
                {
                    customerId = program.UserCheck();
                    validEntry = true;

                }
                else if (resp == "No" || resp == "no")
                {
                    customerId = program.CreateNewUser();
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                }

            }while (validEntry == false);
           

              if (program.loginSuccess == false)
              {
                Console.WriteLine("Enter '1' to try again or '0' to sign up.");
                while (Int32.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == 0)
                    {
                        customerId = program.CreateNewUser();
                        Console.WriteLine("Login Success! Press enter to continue.");
                    }
                    else if (input == 1)
                    {
                        customerId = program.UserCheck();
                        Console.WriteLine("Login Success! Press enter to continue.");
                    }
                    else
                    {
                        Console.WriteLine("                  INVALID ENTRY                 ");
                        Console.WriteLine("Please enter '1' to try again or '0' to sign up.");
                    }
                    continue;
                }
              } else
                {
                Console.WriteLine("Login Success! Press enter to continue.");
                Console.ReadKey();
            }

            bool QuitApp = false;

            while (QuitApp == false)
            {

                bool MenuSelect = false;

                do
                {
                    program.MainMenu();
                    Console.WriteLine("Please make a selection. [1-4]");
                    MenuSelect = Int32.TryParse(Console.ReadLine(), out int select);
                    if (select == 1)
                    {
                        pizzaId = program.PizzaOrder();
                        crustId = program.CrustOrder();
                        topIdOne = program.FirstToppingOrder();
                        if (topIdOne != 8)
                        {
                            topIdTwo = program.SecToppingOrder();
                        }

                        int orderId = program.GetOrderId(pizzaId, crustId, topIdOne, topIdTwo, customerId);
                        newOrder = program.ConfirmOrder(orderId);

                    }
                    else if (select == 2)
                    {
                        program.PrintOrders(customerId);
                        Console.WriteLine("Press enter to return to main menu.");
                        Console.ReadKey();

                    }
                    else if (select == 3)
                    {
                        Console.WriteLine("Please enter the Order Id.");

                        int cancelId = 0;

                        while (!Int32.TryParse(Console.ReadLine(), out cancelId )|| manageOrder.CheckOrder(cancelId) == false){
                            Console.WriteLine("Invalid Order Id entered.");
                            Console.WriteLine("Please enter the Order Id.");
                        }


                        Order cancelOrder = manageOrder.GetOrder(cancelId);
                        List<Order> orders = manageOrder.GetAllOrders(customerId);
                        if (manageOrder.CheckCancelled(cancelId, orders) == true)
                        {
                            Console.WriteLine("Order Id " + cancelId + " is already cancelled.");
                        } else if (manageOrder.UpdateOrder(cancelId, 2) == true)
                        {
                            orders = manageOrder.UpdateOrderStatus(cancelId, orders, 2);
                            Console.WriteLine("Order Id " + cancelId + " is successfully cancelled.");

                        }
                        Console.WriteLine("Press enter to return to main menu.");
                        Console.ReadKey();

                    }
                    else if (select == 4)
                    {
                        QuitApp = true;
                        Console.WriteLine("We hope to see you again soon!");
                    } else
                    {
                        Console.WriteLine("Invalid selection. Please enter 1-4.");
                    }

                } while (MenuSelect == false);
                
            }
            Console.ReadKey();
        }
    }
}
