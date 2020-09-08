using System;
using System.Collections.Generic;

namespace Test.Exercise3
{
    public class Exercise3
    {
        public bool IsItInArrayOrNot(List<double> numbers, double guessNumber)
        {
            return numbers.Exists(x => x.Equals(guessNumber));
        }
    }
}
