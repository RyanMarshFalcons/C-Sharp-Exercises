using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea_Party_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Tea Party program. Lets find out how our upcoming tea party is\ngoing to turn out. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string cupsOrCandy)
        {
            Console.Write($"\nHow many {cupsOrCandy} do we have for the tea party: ");
        }

        public static void NotANumber(string input, string cupsOrCandy)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the number of\n{cupsOrCandy} that we have for the tea party: ");
        }

        public static void CantBeNegative(string cupsOrCandy)
        {
            Console.Write($"\nSorry but the number cannot be negative. Please input the number of {cupsOrCandy}\nthat we have for the tea party: ");
        }

        public static void DisplayResults(string outcome)
        {
            Console.WriteLine($"\nOur tea party is going to be {outcome}. Press enter to close the program.");
        }
    }
}
