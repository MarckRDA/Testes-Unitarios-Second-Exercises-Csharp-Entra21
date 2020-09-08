using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise5
{
    public class Exercise5
    {
        public (double,double,double) EqualLowerOrBiggerThanAvarage(List<double> notes)
        {
            double avarage = 0.0;
            var bigger = 0.0;
            var lower = 0.0;
            var equal = 0.0;

            foreach (var note in notes)
            {
                avarage+=note;
            }

            avarage/=notes.Count;

            foreach (var note in notes)
            {
                if (note > avarage)
                {
                    bigger++;
                }
                else if (note < avarage)
                {
                    lower++;
                }
                else
                {
                    equal++;
                }
            }

            return (bigger,lower,equal);
        }

    }
}
