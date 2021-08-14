using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            var adr = new Address(addressId);


            if (addressId == 1)
            {
                adr.AddressType = 1;
                adr.Country = "Ukraina";
                adr.City = "4g";
                adr.PostalCode = "80100";
                adr.StreetLine12 = "Grinchenka, 5, 40";
            }
            return adr;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address1 = new Address(1)
            {
                AddressType = 1,
                Country = "Ukraina",
                City = "4g",
                PostalCode = "80100",
                StreetLine12 = "Grinchenka, 5, 40"
            };
            addressList.Add(address1);
            Address address2 = new Address(2)
            {
                AddressType = 2,
                Country = "Ukraina",
                City = "Kyiv",
                PostalCode = "12345",
                StreetLine12 = "Balzaka 8-v"
            };
            addressList.Add(address2);
            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
