using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tth.Common.Tests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {   
            //Arrange
            var source = "VasylkoGoblin";
            var expected = "Vasylko Goblin";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesWithExistingSpaces()
        {
            //Arrange
            var source = "Vasylko Goblin";
            var expected = "Vasylko Goblin";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
