using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ArraySample2
    {
        public void ArraySamplers()
        {
            double[] temperature = {-5,-6,70,30,20,10,40,60 };

            foreach (double temp in temperature)
            {
                if (temp <= 0)
                {
                    Console.WriteLine($"Temp : {temp} - Cold");
                }
                else if (temp >= 0 && temp <= 20)
                {
                    Console.WriteLine($"Tepm : {temp} - Moderate");
                }
                else
                {
                    Console.WriteLine($"Temp : {temp} - Hot");
                }
            }

        }
    }
}
