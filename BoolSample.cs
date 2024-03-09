using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class BoolSample
    {
        public void BoolSample1() 
        {
            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(result);
            bool result1 = message.Contains("Cat");
            Console.WriteLine(result1);
        }
    }
}
