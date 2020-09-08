using System;

namespace Test.Exercise2
{
    public class Exercise2
    {
        public double[] PrintingInDirectOrder(double[] numbers)
        {
            var returnedArray = new double[10];
            for (int i = 0; i < numbers.Length ; i++)
            {
                returnedArray[i] = numbers[i];
            }      

            return returnedArray;     
        }

        public double[] PrintingInReverseOrder(double[] numbers)
        {
            var returnedArray = new double[10];
            for (int i = numbers.Length; i > 0 ; i--)
                returnedArray[numbers.Length - i] = numbers[i - 1];

            return returnedArray;
        }
    }
}
