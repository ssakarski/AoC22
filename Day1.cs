using System;
using System.Collections.Generic;
using System.Linq;
namespace AoC22
{
    public class Day1
    {
        public static void printCalories()
        {
            string[] inputs = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\AoC22\Inputs\Day1.txt");
            int currCalories = 0;
            int maxCalories = 0;
            List<int> calories = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if(inputs[i] == "")
                {
                    if(currCalories > maxCalories)
                    {
                        maxCalories = currCalories;
                    }
                    calories.Add(currCalories);
                    currCalories = 0;
                    continue;
                }
                currCalories += int.Parse(inputs[i]);
            }

            Console.WriteLine(maxCalories);
        }

        public static void printTopThreeCalories()
        {
            string[] inputs = System.IO.File.ReadAllLines(@"C:\Users\User\source\repos\AoC22\Inputs\Day1.txt");
            int currCalories = 0;
            int maxCalories = 0;
            List<int> calories = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == "")
                {
                    if (currCalories > maxCalories)
                    {
                        maxCalories = currCalories;
                    }
                    calories.Add(currCalories);
                    currCalories = 0;
                    continue;
                }
                currCalories += int.Parse(inputs[i]);
            }

            calories = calories.OrderByDescending(x => x).ToList();
            Console.WriteLine(calories[0]+calories[1]+calories[2]);
        }
    }
}
