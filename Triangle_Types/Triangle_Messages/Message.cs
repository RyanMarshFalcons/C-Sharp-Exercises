using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Triangle program where you tell me what the lengths of\nthe three sides of your triangle are and I tell you what type of triangle you\nhave. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string sideNumber)
        {
            Console.Write($"\nPlease input the length of the {sideNumber} side of your triangle: ");
        }

        public static void NotANumber(string input, string sideNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the length of the {sideNumber}\nside of your triangle: ");
        }

        public static void MustBePositive(string sideNumber)
        {
            Console.Write($"\nSorry but side lengths must be positive. Please input the length of the {sideNumber}\nside of your triangle: ");
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("\nERROR A triangle with your triangle's dimensions cannot exist!!!");
        }

        public static void DisplayResults(string triangleType)
        {
            Console.WriteLine($"\nYour triangle is {triangleType}. Press enter to close the program.");
        }
    }
}
