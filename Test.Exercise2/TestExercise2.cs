using System;
using Xunit;

namespace Test.Exercise2
{
    public class TestExercise2
    {
        [Fact]
        public void Should_Return_An_Array_In_A_Direct_Order()
        {
            //Given
            var exercise2 = new Exercise2();

            //When
            var arrayTest = new double[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var result = exercise2.PrintingInDirectOrder(arrayTest);

            //Then
            for (int i = 0; i < arrayTest.Length; i++)
            {
                Assert.Equal(arrayTest[i], result[i]);
            }
        }

        [Fact]
        public void Should_Return_An_Array_In_A_Reverse_Order()
        {
            //Given
            var exercise2 = new Exercise2();

            //When
            var arrayTest = new double[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var expectedResult = exercise2.PrintingInReverseOrder(arrayTest);

            //Then
            for (int i = 0; i < arrayTest.Length; i++)
            {
                Assert.Equal(arrayTest[9 - i], expectedResult[i]);
            }
        }
    }
}
