using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise6
{
    public class TestExercise6
    {
        List<double> listNumbersA = new List<double>()
        {
            10, 90, 37, 65, 23, 84, -2, -7, -4, -5, 0, -9
        };

        List<double> listNumbersB = new List<double>()
        {
            100, -222, 32, 40, -77,-46, 21, 10, -8, -7, 2, -43
        };

        [Fact]
        public void Should_Return_A_List_Shorted()
        {
            //Given
            var exercise6 = new Exercise6();

            //When
            var result = exercise6.DirectOrderArray(listNumbersA);
            var expectedResult = new List<double>()
            {
                -9, -7, -5, -4, -2, 0, 10, 23, 37, 65, 84, 90
            };

            //Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Return_A_List_Shorted_Reversely()
        {
            //Given
            var exercise6 = new Exercise6();

            //When
            var result = exercise6.ReverseOrderArray(listNumbersB);
            var expectedResult = new List<double>()
            {
                100, 40, 32, 21, 10, 2, -7, -8, -43, -46, -77, -222
            };

            //Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Return_A_List_Shorted_With_Sum_Between_ListA_And_ListB()
        {
            //Given
            var exercise6 = new Exercise6();
           
            //When
            var result = exercise6.SumListA_B_AndSortedList(listNumbersA, listNumbersB);
            var expectedResult = new List<double>()
            {
               -132, -6, 2, 3, 7, 8, 15, 17, 19, 27, 33, 91 
            };

            //Then
            Assert.Equal(expectedResult, result);
        }

    }
}
