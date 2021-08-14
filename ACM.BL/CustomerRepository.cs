using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);


            if (customerId == 1)
            {
                customer.EmailAddress = "mykolaivladyslavovych@u.ua";
                customer.FirstName = "jahab";
                customer.LastName = "validator";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).ToList();
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
