using System;
using Xunit;

namespace Test.Exercise2
{
    public class TestExercise2
    {
        [Theory]
        [InlineData(new double[]{1, 3, 4, 5, 6, 9, 8, 7, 4, 0}, new double[]{0, 1, 3, 4, 4, 5, 6, 7, 8, 9})]
        [InlineData(new double[]{-5, -3, 0, -9, -7, -4, -11, -10, -63, -80}, new double[]{-80, -63, -11, -10, -9, -7, -5, -4, -3, 0})]
        public void Should_Return_An_Array_In_A_Direct_Order(double[] desorderedArray,  double[] orderedArray)
        {
            //Given
            var exercise2 = new Exercise2();

            //When
            var result = exercise2.PrintingInDirectOrder(desorderedArray);

            //Then
            Assert.Equal(orderedArray, result);
        }

        [Theory]
        [InlineData(new double[]{1, 3, 4, 5, 6, 9, 8, 7, 4, 0}, new double[]{9, 8, 7, 6, 5, 4, 4, 3, 1, 0})]
        [InlineData(new double[]{-5, -3, 0, -9, -7, -4, -11, -10, -63, -80}, new double[]{0, -3, -4, -5, -7, -9, -10, -11, -63, -80})]
        public void Should_Return_An_Array_In_A_Reverse_Order(double[] desorderedArray,  double[] orderedArray)
        {
            //Given
            var exercise2 = new Exercise2();

            //When
            var result = exercise2.PrintingInReverseOrder(desorderedArray);

            //Then
            Assert.Equal(orderedArray, result);
        }
    }
}
