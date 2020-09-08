namespace Test.Exercise1
{
    public class Exercise1
    {
        public double[] ArrayCMixUp(double[] arrayA, double[] arrayB)
        {
            double[] arrayC = new double[15];

            for (int index = 0; index < arrayC.Length; index++)
            {
                arrayC[index] = arrayA[index] - arrayB[index];
            }  

            return arrayC;
        }
    }
}
