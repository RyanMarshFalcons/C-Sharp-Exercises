using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public static class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my reverse a string program where you enter any string of\ncharacters and I reverse them for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterString()
        {
            Console.Write("Input any amount of characters that you please and then I will display them in \nreverse: ");
        }

        public static void DisplayStringInReverse(string reversedString)
        {
            Console.WriteLine($"\nThe reverse of what you input is: {reversedString}");
        }

    }
}
