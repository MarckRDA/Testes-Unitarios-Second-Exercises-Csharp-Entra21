using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise6
{
    public class Exercise6
    {
        public List<double> DirectOrderArray(List<double> numbersA)
        {
            numbersA.Sort();
            return numbersA;
        }

        public List<double> ReverseOrderArray(List<double> numbersB)
        {
            numbersB.Sort();
            numbersB.Reverse();
            return numbersB;
        }
        
        public List<double> SumListA_B_AndSortedList(List<double> numbersA, List<double> numbersB)
        {
            var numbersC = new List<double>();

            numbersA.Sort();
            numbersB.Sort();
            numbersB.Reverse();
            
            for (int index = 0; index < numbersA.Count; index++)
            {
                numbersC.Add(numbersA[index] + numbersB[index]);
            }
            numbersC.Sort();
            return numbersC;
        }
    }
}
