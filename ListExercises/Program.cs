using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            printEven(nums);

            List<string> strs = new List<string> {"first", "second", "third", "one", "two"};
            printStr(strs);

            Console.WriteLine("Enter the word length you want to search for: ");
            int wordLength = Convert.ToInt32(Console.ReadLine());
            printStrDynamic(strs, wordLength);
        }
        static public void printEven(List<int> nums)
        {
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
        }

        static public void printStr(List<string> strs)
        {
            foreach (string str in strs)
            {
                if (str.ToString().Length == 5)
                    Console.WriteLine(str);
            }
        }

        static public void printStrDynamic(List<string> strs, int length)
        {
            foreach (string str in strs)
            {
                if (str.ToString().Length == length)
                    Console.WriteLine(str);
            }
        }
    }
}
