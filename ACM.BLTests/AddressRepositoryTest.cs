using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class AddressRepositoryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            //-Arrange
            var adrep = new AddressRepository();
            var expected = new Address(1)
            {
                AddressType = 1,
                Country = "Ukraina",
                City = "4g",
                PostalCode = "80100",
                StreetLine12 = "Grinchenka, 5, 40"
        };

            //--Act

            var actual = adrep.Retrieve(1);

            //--Assert

            Assert.Equal(expected.AddressType, actual.AddressType);
            Assert.Equal(expected.Country, actual.Country);
            Assert.Equal(expected.City, actual.City);
            Assert.Equal(expected.PostalCode, actual.PostalCode);
            Assert.Equal(expected.StreetLine12, actual.StreetLine12);




        }

    }
}
