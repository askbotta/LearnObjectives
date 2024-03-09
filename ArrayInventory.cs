using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObjectives
{
    public class ArrayInventory
    {
        public void ArrayInventory1()
        {
            string[] inventory = { "Sword", "Health Potion", "Shield", "Mana Potion", "Bow" };

            foreach (string item in inventory)
            {
                if (item.Contains("Potion"))
                {
                    Console.WriteLine($"Using {item} to restore your stats");
                }
                else if (item.Contains("Sword") || item.Contains("Bow"))
                {
                    Console.WriteLine($"Using {item} to fight yourself");
                }
                else if (item.Contains("Shield"))
                {
                    Console.WriteLine($"Using {item} to protect yourslf");
                }
                else
                {
                    Console.WriteLine($"Found an unknown item : {item}.");
                }
            }
        }

    }
}
