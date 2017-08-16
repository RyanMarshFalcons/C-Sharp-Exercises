using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Around_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Middle Around program where you will enter a string and then I will add on the middle character(s) of your string to both the front and the back of your string. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least three characters to form your string: ");
        }

        public static void AtLeastThreeCharacters()
        {
            Console.Write("\nSorry but you must input at least three characters to create a valid string.\nPlease try again: ");
        }

        public static void DisplayNewString(string newString)
        {
            Console.WriteLine($"\nAfter adding the center of your string middle around your old string your new\nstring is: {newString}\nPress enter to close the program.");
        }
    }
}
