using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class CustomerTest
    {
        [Fact]
        public void ToStringTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Diablo";
            Customer.InstanceCount += 1;
            var expected = "Diablo";


            // Act
            var actual = c1.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Diablo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Archangel";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Gospodj";
            Customer.InstanceCount += 1;


            // Act


            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }



        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Djonik",
                LastName = "Chegeskiy"
            };
            var expected = "Chegeskiy, Djonik";


            // Act
            string actual = customer.FullName;


            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Chegeskiy"
            };
            var expected = "Chegeskiy";


            // Act
            string actual = customer.FullName;


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Djonik",
            };
            var expected = "Djonik";


            // Act
            string actual = customer.FullName;


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Ziggie",
                EmailAddress = "zaziz@123.ua"
            };

            var expected = true;

            //Act
            var result = customer.Validate();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
                EmailAddress = "zaziz@123.ua"
            };

            var expected = false;

            //Act
            var result = customer.Validate();

            //Assert
            Assert.Equal(expected, result);
        }


    }
}
