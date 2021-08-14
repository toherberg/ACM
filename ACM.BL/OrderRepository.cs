using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 1)
                order.OrderDate = DateTimeOffset.Parse("13.06.1993");

            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //insert new
                    }
                    else
                    {
                        //update existing
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;

        }
    }
}
    

