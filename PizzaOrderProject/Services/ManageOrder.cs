using PizzaOrderProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderProject.Services
{
    public class ManageOrder
    {
        readonly StoreContext context;

        public ManageOrder()
        {
            context = new StoreContext();
        }

        public Pizza GetPizza(int id)
        {
            Pizza myPizza = context.Pizza.Where(p => p.Id == id).FirstOrDefault();
            return myPizza;
        }

        public Crust GetCrust(int id)
        {
            Crust myCrust = context.Crust.Where(c => c.Id == id).FirstOrDefault();
            return myCrust;
        }

        public Topping GetTopping(int id)
        {
            Topping myTopping = context.Toppings.Where(t => t.Id == id).FirstOrDefault();
            return myTopping;
        }
        
       public int AddOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return order.Order_Id;
        }

        public Order GetOrder(int id)
        {
            Order myOrder = context.Orders.Where(o => o.Order_Id == id).FirstOrDefault();
            return myOrder;
        }

        public List<Order> GetAllOrders(int customerId)
        {

            return context.Orders.Where( o => o.Customer_Id == customerId).ToList();

        }

        public List<Order> UpdateOrderStatus(int orderId, List<Order> orderList, int idx)
        {
            int index = orderList.FindIndex(o => o.Order_Id == orderId);
            if (idx == 0)
            {
                orderList[index].Order_Status = "Pending Confirmation";
            } else if (idx == 1){
                orderList[index].Order_Status = "Order Confirmed";
            } else if (idx == 2)
            {
                orderList[index].Order_Status = "Order Cancelled";
            }
            return orderList;
        }

        public bool CheckCancelled(int orderId, List<Order> orderList)
        {
            int index = orderList.FindIndex(o => o.Order_Id == orderId);
            if (orderList[index].Order_Status == "Order Cancelled")
            {
                return true;
            }
            return false;

        }

        public bool CheckOrder (int orderId)
        {
            Order myOrder = context.Orders.Where(o => o.Order_Id == orderId).FirstOrDefault();
            if (myOrder != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateOrder(int orderId, int idx)
        {
            Order myOrder = context.Orders.Where(o => o.Order_Id == orderId).FirstOrDefault();
            if(idx == 1)
            {
                myOrder.Order_Status = "Order Confirmed";
            } else if (idx == 2){

                myOrder.Order_Status = "Order Cancelled";

            } else if(idx == 0)
            {
                myOrder.Order_Status = "Pending Confirmation";
            }
            context.SaveChanges();
            return true;

        }
       

    }
}
