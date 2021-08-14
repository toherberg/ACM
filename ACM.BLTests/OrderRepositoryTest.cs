using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class OrderRepositoryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            //-Arrange
            var rep = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = DateTimeOffset.Parse("13.06.1993")
            };

            //--Act

            var actual = rep.Retrieve(1);

            //--Assert

            Assert.Equal(expected.OrderId, actual.OrderId);
            Assert.Equal(expected.OrderDate, actual.OrderDate);


        }

    }
}
