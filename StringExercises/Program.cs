using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse.";

            string[] strArray = str.Split("");
            Console.WriteLine(string.Join(",", strArray));

            string[] strArray2 = str.Split(".");
            Console.WriteLine(string.Join(",", strArray2));
        }
    }
}
