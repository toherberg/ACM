using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class ProductRepostioryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            //-Arrange
            var prodrep = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Napas",
                ProductDescription = "smachnyi dyzhe",
                CurrentPrice = 2500,
        };

            //--Act

            var actual = prodrep.Retrieve(1);

            //--Assert

            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductId, actual.ProductId);




        }

    }
}
