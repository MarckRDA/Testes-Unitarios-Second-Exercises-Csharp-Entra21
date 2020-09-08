using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise5
{
    public class TestExercise5
    {
        [Fact]
        public void Should_Return_How_Many_Elements_Are_Above_Over_And_Equal_Avarage()
        {
            //Given
            var exercise5 = new Exercise5();
            var listNotes = new List<double>()
            {
                10, 7.6, 3, 4, 8, 9, 10, 2, 4, 5.5, 4.3, 1.3, 6.7, 8.9, 7.1
            };

            //When
            var result = exercise5.EqualLowerOrBiggerThanAvarage(listNotes);

            Assert.Equal((8, 7, 0),result);
        }
    }
}
