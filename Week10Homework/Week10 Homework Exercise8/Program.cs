using System;
using System.Linq;
using System.Collections;
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
                if (kvp.Value == integerArray.Length / 2 + 1)
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
            //exercise 2 removing integers that appear odd number of times
            List<int> integerList = new List<int>{ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            var occurences = integerList.GroupBy(x => x).ToDictionary(y => y.Key, z => z.Count());

            foreach (var item in occurences.ToArray())
            {
                if (item.Value%2 != 0)
                {
                    integerList.ToArray();
                    for (int i = 0; i < integerList.Count + 1; i++)
                    {
                        integerList.Remove(item.Key);
                    }
                }
                Console.WriteLine(item);
            }
            foreach (var item in integerList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
