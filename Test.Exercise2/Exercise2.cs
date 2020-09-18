using System;
using System.Linq;

namespace Test.Exercise2
{
    public class Exercise2
    {
        public double[] PrintingInDirectOrder(double[] numbers) => numbers.ToList().OrderBy(n => n).ToArray();
        

        public double[] PrintingInReverseOrder(double[] numbers) => numbers.ToList().OrderByDescending(n => n).ToArray();
        
    }
}
