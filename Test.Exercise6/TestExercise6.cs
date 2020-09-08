using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise6
{
    public class TestExercise6
    {
        [Fact]
        public void Should_Return_A_List_Shorted()
        {
            //Given
            var exercise6 = new Exercise6();
            var listNumbers = new List<double>()
            {
                1,2,3,4,5,7,2,3,4,5,6,7
            };

            //When
            var result = exercise6.DirectOrderArray(listNumbers);

            //Then
            Assert.Collection(
                result,
                item1 => {Assert.Equal(1,item1);},
                item2 => {Assert.Equal(2,item2);},
                item3 => {Assert.Equal(2,item3);},
                item4 => {Assert.Equal(3,item4);},
                item5 => {Assert.Equal(3,item5);},
                item6 => {Assert.Equal(4,item6);},
                item7 => {Assert.Equal(4,item7);},
                item8 => {Assert.Equal(5,item8);},
                item9 => {Assert.Equal(5,item9);},
                item10 => {Assert.Equal(6,item10);},
                item11 => {Assert.Equal(7,item11);},
                item12 => {Assert.Equal(7,item12);}
            );
        }

        [Fact]
        public void Should_Return_A_List_Shorted_Reversely()
        {
            //Given
            var exercise6 = new Exercise6();
            var listNumbers = new List<double>()
            {
                100,222,32,40,77,46,21,10,8,7,2,43
            };

            //When
            var result = exercise6.ReverseOrderArray(listNumbers);

            //Then
            Assert.Collection(
                result,
                item1 => {Assert.Equal(222,item1);},
                item2 => {Assert.Equal(100,item2);},
                item3 => {Assert.Equal(77,item3);},
                item4 => {Assert.Equal(46,item4);},
                item5 => {Assert.Equal(43,item5);},
                item6 => {Assert.Equal(40,item6);},
                item7 => {Assert.Equal(32,item7);},
                item8 => {Assert.Equal(21,item8);},
                item9 => {Assert.Equal(10,item9);},
                item10 => {Assert.Equal(8,item10);},
                item11 => {Assert.Equal(7,item11);},
                item12 => {Assert.Equal(2,item12);}
            );
            
            
           
        }

        [Fact]
        public void Should_Return_A_List_Shorted_With_Sum_Between_ListA_And_ListB()
        {
            //Given
            var exercise6 = new Exercise6();
            var listA = new List<double>()
            {
                1,2,3,4,5,7,2,3,4,5,6,7
            };
            var listB = new List<double>()
            {
                100,222,32,40,77,46,21,10,8,7,2,43
            };

            //When
            var result = exercise6.SumListA_B_AndSortedList(listA, listB);

            //Then
            Assert.Collection(
                result,
                item1 => {Assert.Equal(9,item1);},
                item2 => {Assert.Equal(14,item2);},
                item3 => {Assert.Equal(14,item3);},
                item4 => {Assert.Equal(15,item4);},
                item5 => {Assert.Equal(26,item5);},
                item6 => {Assert.Equal(36,item6);},
                item7 => {Assert.Equal(44,item7);},
                item8 => {Assert.Equal(46,item8);},
                item9 => {Assert.Equal(49,item9);},
                item10 => {Assert.Equal(79,item10);},
                item11 => {Assert.Equal(102,item11);},
                item12 => {Assert.Equal(223,item12);}
            ); 
        }

    }
}
