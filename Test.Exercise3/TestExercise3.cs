using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise3
{
    public class TestExercise3
    {
        [Theory]
        [InlineData(3)]
        [InlineData(65)]
        [InlineData(1)]
        public void Should_Return_Whether_There_Is_A_Number_In_List_Or_Not(double guessNumber)
        {
            //Given
            var exercise3 = new Exercise3();
            var numbersList = new List<double>()
            {
                1, 3, 4, 65, 1, 23, 4, 5, 7, 8
            };

            //When
            var result = exercise3.IsItInArrayOrNot(numbersList, guessNumber);

            //Then
            Assert.True(result);
        }
    }
}
