using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ArrayExecution
    {
        public void ArrayExcecution1()
        {
            int[] scores = { 45,82,67,30,95,55,40, 78 };    

            foreach (int score in scores)
            {
                if (score > 50)
                {
                    Console.WriteLine($"score : {score}-Pass");
                }
                else
                {
                    Console.WriteLine($"score : {score}-Fail");
                }
            }

        }
    }
}
