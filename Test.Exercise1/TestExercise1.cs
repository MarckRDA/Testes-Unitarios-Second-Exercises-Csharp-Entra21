using System;
using Xunit;

namespace Test.Exercise1
{
    public class TestExercise1
    {
        [Fact]
        public void Should_Return_A_Subtraction_Between_ArrayA_And_ArrayB()
        {
            //Given
            var exercise1 = new Exercise1();

            //When
            var arrayA = new double[15]
            {
                1,5,4,2,6,7,8,9,4,3,2,1,2,3,4
            };

            var arrayB = new double[15]
            {
                5,7,8,9,3,2,1,3,4,5,7,9,0,1,2
            };

            var result = exercise1.ArrayCMixUp(arrayA, arrayB);

            //Then
            for (int index = 0; index < 15; index++)
            {
                Assert.Equal(arrayA[index] - arrayB[index], result[index]);
            }
        }
    }
}
