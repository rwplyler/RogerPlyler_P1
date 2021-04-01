using System;
using Xunit;

namespace TestPizzaBox
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void ToppingName(int expected, int testID)
        {
            

            // assert
            Assert.Equal(expected, testID);
        }
        
    }
}
