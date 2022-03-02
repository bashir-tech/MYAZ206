using array;
using System;
using Xunit;

namespace ArrayTest
{
    public class ArrayTest
    {
        [Fact]
        public void  ArraySetValueTest()
        {
            // Arrange
            var arr = new DSArray();
            //Act
            arr.SetValue(10, 0);
            //Asseret
            Assert.Equal(10, arr.GetValue(0));
        }


        
        public void checkClonable()
        {
            var arr = new DSArray(4);

            var cloderarr = arr.Clone();
            Assert.IsType<DSArray>(cloderarr);
        }
    }
}