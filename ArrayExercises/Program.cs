﻿using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] nums = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
