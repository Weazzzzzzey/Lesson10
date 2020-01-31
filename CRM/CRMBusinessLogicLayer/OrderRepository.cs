using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    class OrderRepository
    {

        public Order Retrieve(int OrderID)
        {
            Order Order = new Order();

            if (OrderID == 1)
            {
                Order.Customer = "Dee";
                Order.OrderDate = DateTime.Now;
                Order.ShipingAddress = "";
                Order.OrdersItems = 4;
            }
            return Order;
        }

        public bool Save()
        {
            //code that save the default Order
            return true;
        }

    }
}
