using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ForEachBasics
    {
        public void ForEachBasics1()
        {
            string[] names = { "raj", "rohit", "kalyan", "purohit" };
            foreach (string name in names)
            {
             Console.WriteLine(name);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int numberSum = 0;
            int bin = 0;
            foreach(int number in numbers)
            {
                numberSum += number;
                bin++;
               // Console.WriteLine($"Bin {bin} = {number} items (Running total: {numberSum})");
                //Console.WriteLine($"We have {numberSum} items in inventory.");
            }
            Console.WriteLine($"We have {numberSum} items in inventory.");

        }
    }
}
