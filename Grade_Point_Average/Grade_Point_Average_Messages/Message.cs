using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Point_Average_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Grade Point Average program. Input the letter grades (F,D-, D, D+, C-, C, C+, B-, B, B+, A-, or A) that you recieved for each class on\nyour schedule and I will calculate your GPA for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterGrade(string className)
        {
            Console.Write($"\nPlease enter the letter grade that you recieved in {className}: ");
        }

        public static void NotAGrade(string input, string className)
        {
            Console.Write($"\nSorry but {input} is not a grade. Please enter the letter grade that you\nrecieved in {className}: ");
        }

        public static void DisplayGradePointAverage(double gradePointAverage)
        {
            Console.WriteLine($"\nYour grade point average for the semester is {gradePointAverage} Press enter to continue.");
        }
    }
}
