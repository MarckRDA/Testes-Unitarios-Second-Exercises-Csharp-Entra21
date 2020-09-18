using System;
using System.Collections.Generic;

namespace Test.Exercise4
{
    public class Exercise4
    {
        public bool EqualityBetweenArrays(List<double> listOne, List<double> listTwo)
        {
            var flag = 0;

            foreach (var item in listOne)
            {
                if(listTwo.Exists(x => x.Equals(item)))
                {
                    flag++;
                }
            }

            if(flag == listOne.Count)
            {
                return true;
            }

            return false;
        } 

    }
}
