using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ArrayStringSample
    {
        public void ArrayStringSample1() 
        {
            string[] names = { "Alice", "Bob", "Charlie", "Diana", "Evan", "Fiona" };
            foreach (string name in names)
            {
                if (name[0] < 'D')
                {
                    Console.WriteLine($"{name}   belongs to Group A.");
                }
                else
                {
                    Console.WriteLine($"{name}   belongs to Group B.");
                }

            }
        }
    }
}
