using System;
using System.Linq;
using System.Collections.Generic;

namespace Week10_Homework_Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int[] uniqueIntegers = integerArray.Distinct().ToArray();
            Dictionary<int, int> uniqueDict = new Dictionary<int, int>();
            int majorant = 0;
            foreach (int i in integerArray)
            {
                if (uniqueDict.ContainsKey(i))
                {
                    int value = uniqueDict[i];
                    value++;
                    uniqueDict[i] = value;
                }
                else
                {
                    uniqueDict.Add(i, 1);
                }
            }
            for (int i = 0; i < uniqueDict.Count; i++)
            {
                Console.WriteLine("Value {0} is repeated {1} times", uniqueDict.Keys.ElementAt(i), uniqueDict[uniqueDict.Keys.ElementAt(i)]);
            }
            foreach (var kvp in uniqueDict)
            {
                if (kvp.Value == integerArray.Length/2 + 1)
                {
                    majorant = kvp.Key;
                }
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            if (majorant == 0)
            {
                Console.WriteLine("The majorant does not exist!");
            }
            else
            {
                Console.WriteLine("The majorant is {0}", majorant);
            }
        }
    }
}
