using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise4
{
    public class TestExercise4
    {
        [Fact]
        public void Should_Return_Whether_An_Array_Is_Equal_Another()
        {
            //Given
            var exercise4 = new Exercise4();
            var listOne = new List<double>()
            {
                2,5,4,1,6,7,8,10,3,56
            };

            var listTwo = new List<double>()
            {
                56,2,5,1,4,6,8,10,3,7
            };

            //When
            var result = exercise4.EqualityBetweenArrays(listOne,listTwo);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void Should_Return_Whether_An_Array_Is_Equal_Another_With_Negative_Numbers()
        {
            //Given
            var exercise4 = new Exercise4();
            var listOne = new List<double>()
            {
                -9, -6, -15, -54, -2, -4, -8, -1, -56, -24
            };

            var listTwo = new List<double>()
            {
                -54, -24, -4, -1, -9, -6, -56, -15, -8, -2
            };

            //When
            var result = exercise4.EqualityBetweenArrays(listOne,listTwo);

            //Then
            Assert.True(result);
        }
    }
}
