using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class SubScribtionProgram
    {
        public void SubScribtionProgram1()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            Console.WriteLine(daysUntilExpiration);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }
    }
}
