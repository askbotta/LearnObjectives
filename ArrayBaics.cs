using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ArrayBaics
    {
        public void ArrayBasic()
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            Console.WriteLine($"First number : {fraudulentOrderIDs[0]}");
            fraudulentOrderIDs[1] = "B456";
            Console.WriteLine($"Second Index Number : {fraudulentOrderIDs[1]}");
            fraudulentOrderIDs[2] = "C789";
            Console.WriteLine(fraudulentOrderIDs[2]);
            //fraudulentOrderIDs[3] = "C709";
            //Above index is out of boundry

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign number : {fraudulentOrderIDs[0]}");
        }

    }
}
