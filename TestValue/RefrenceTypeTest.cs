using ValueAndRefrence;
using Xunit;

namespace TestValue
{
    public class RefrenceTypeTest
    {
        [Fact]
        public void RefrenecTypeTest()
        {
            //Arrange
            var p1 = new RefrenceType(3, 4);
            var p2 = p1;
            //Act
            p2.X = 10;
            //Assert
            Assert.Equal(p1.X, p2.X);
        }

        [Fact]
        public void ValuType()
        {
            //Arrange
            var p1 = new ValueType(3, 4);
            var p2 = p1;
            //Act
            p2.X = 10;
            //Assert
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void SwapTest()
        {
            //arrange
            var reftype = new RefrenceType();
            int a = 23, b = 55;
            //Act
            reftype.SwapByValue(a, b);
            //Assert
            Assert.Equal(23, a);
            Assert.Equal(55, b);
        }

    }
}