using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        private static readonly object input = "";

        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudentID;
            string newStudentName;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student ID: ");
                string input = Console.ReadLine();
                newStudentID = Convert.ToInt32(input);

                if (!Equals(newStudentID, 0))
                {
                    Console.WriteLine("Name: ");
                    newStudentName = Console.ReadLine();
                    students.Add(newStudentID, newStudentName);
                    Console.ReadLine();
                }

            } while (!Equals(newStudentID, 0));

            // Print class roster
            Console.WriteLine("\nClass roster:");            

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value + " ");
            }

        }
    }
}
