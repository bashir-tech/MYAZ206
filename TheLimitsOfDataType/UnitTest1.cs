using Xunit;

namespace TheLimitsOfDataType
{
    public class UnitTest1
    {
        [Fact]
        public void Byte_Data_Type_Minvalue_MaxValue()
        {
            // Arrange

            byte Minalue;
            byte Maxvalue;

            //Act
            Minalue = 0;
            Maxvalue = 255;


            //Assert
            Assert.Equal(Minalue, byte.MinValue);

            Assert.Equal(Maxvalue, byte.MaxValue);




        }
    }
}