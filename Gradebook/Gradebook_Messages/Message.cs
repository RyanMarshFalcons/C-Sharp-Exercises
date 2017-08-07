using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Gradebook program. Input all the grades that you\nrecieved on assignments for your class and I will tell you what your final gradeis. Press enter to continue.");
            Console.ReadLine();
        }

        public static void AddAnotherGrade()
        {
            Console.Write("\nWould you like to add another grade to the gradebook? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void EnterGrade()
        {
            Console.Write("\nPlease enter the number of points that you recieved on the assignment: ");
        }

        public static void NotAGrade(string input)
        {
            Console.Write($"\nSorry but {input} is not a grade. Pease enter the number of points that you\nrecieved on the assignment: ");
        }

        public static void MustBeBetween0and100()
        {
            Console.Write($"\nGrades can only be between 0 and 100. Pease enter the number of points that you recieved on the assignment: ");
        }

        public static void DisplayGrade(double grade, string letterGrade)
        {
            Console.WriteLine($"\nYour final grade for the class is {grade} which translates into a {letterGrade}.\nPress enter to continue.");
        }
    }
}
