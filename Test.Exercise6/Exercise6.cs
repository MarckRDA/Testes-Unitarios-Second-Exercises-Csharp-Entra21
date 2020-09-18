using System.Collections.Generic;
using System.Linq;

namespace Test.Exercise6
{
    public class Exercise6
    {
        public List<double> DirectOrderArray(List<double> numbersA) => numbersA.OrderBy(x => x).ToList();

        public List<double> ReverseOrderArray(List<double> numbersB) => numbersB.OrderByDescending(x => x).ToList();

        public List<double> SumListA_B_AndSortedList(List<double> numbersA, List<double> numbersB)
        {
            var numbersC = DirectOrderArray(numbersA).Zip(ReverseOrderArray(numbersB), (n1, n2) => n1 + n2).OrderBy(n => n).ToList();
            return numbersC;
        }
    }
}
