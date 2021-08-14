using System;
using System.Collections.Generic;
using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class CustomerRepositoryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            //-Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mykolaivladyslavovych@u.ua",
                FirstName = "jahab",
                LastName = "validator"
        };

            //--Act

            var actual = customerRepository.Retrieve(1);

            //--Assert

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);


        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mykolaivladyslavovych@u.ua",
                FirstName = "jahab",
                LastName = "validator",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        Country = "Ukraina",
                        City = "4g",
                        PostalCode = "80100",
                        StreetLine12 = "Grinchenka, 5, 40"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        Country = "Ukraina",
                        City = "Kyiv",
                        PostalCode = "12345",
                        StreetLine12 = "Balzaka 8-v"
                    }
                }
            };

        



            //--Act

            var actual = customerRepository.Retrieve(1);

            //--Assert

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);


            for (int i = 0; i <= 1; i++) 
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].StreetLine12, actual.AddressList[i].StreetLine12);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }


        }

    }
}
