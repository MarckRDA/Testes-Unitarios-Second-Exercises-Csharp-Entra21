using System;
using Xunit;

namespace Test.Exercise1
{
    public class TestExercise1
    {
        [Theory]
        [InlineData(new double[] {1,5,4,2,6,7,8,9,4,3,2,1,2,3,4}, new double[]{5,7,8,9,3,2,1,3,4,5,7,9,0,1,2})]
        public void Should_Return_A_Subtraction_Between_ArrayA_And_ArrayB(double[] arrayA, double[] arrayB)
        {
            //Given
            var exercise1 = new Exercise1();

            //When
            var result = exercise1.ArrayCMixUp(arrayA, arrayB);

            //Then
            for (int index = 0; index < 15; index++)
            {
                Assert.Equal(arrayA[index] - arrayB[index], result[index]);
            }
        }
    }
}
