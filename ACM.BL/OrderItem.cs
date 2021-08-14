using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }

        public int ProductID{ get; private set; }
        public int OrderItemID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        public OrderItem Retreive(int orderItemId)
        {

            return new OrderItem();
        }

        //retrieve list of all products in db
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        //save product (new or changes to existing)
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity <=0) isValid = false;
            if (ProductID<=0) isValid = false;
            if (PurchasePrice == null) isValid = false;


            return isValid;
        }

    }
}
