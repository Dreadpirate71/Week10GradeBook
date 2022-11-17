using System;
using System.Collections.Generic;
using System.Linq;

namespace Week10Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>();
            string userInput = null;
            int sumIntegerList = 0;
            int averageIntegerList = 0;
            do
            {
                Console.WriteLine("Please enter a positive integer:");
                userInput = Console.ReadLine();
                try
                {
                    int enteredInteger = int.Parse(userInput);
                    if (enteredInteger < 0)
                    {
                        Console.WriteLine("You did not enter a positive integer. Please try again!");
                        continue;
                    }
                    integerList.Add(enteredInteger);
                    sumIntegerList += enteredInteger;
                    averageIntegerList = sumIntegerList / integerList.Count;
                }
                
                catch (System.FormatException)
                {
                    Console.WriteLine("You did not enter a number so the program will now exit!");
                    Environment.Exit(1);
                };
                Console.WriteLine("You have entered {0} numbers so far.", integerList.Count);
                Console.WriteLine("The total of the numbers you have entered is {0}", sumIntegerList);
                Console.WriteLine("The average of the numbers you have entered is: {0}", averageIntegerList);

                continue;
            } while (userInput != null);
            
            int[] integerArray = {2,2,3,3,2,3,4,3,3};
            int[] uniqueIntegers = integerArray.Distinct().ToArray();
            foreach (int integer in uniqueIntegers)
            {
                Console.WriteLine(integer);
            }
           
            

        }
    }
}
