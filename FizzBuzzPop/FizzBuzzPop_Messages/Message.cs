using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPop_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my FizzBuzzPop program where I'll be counting from 1 to 250 while\nreplacing numbers divisible by 3 with the word Fizz, numbers divisible by 5 withthe word Buzz, numbers divisible by 7 with the word Pop, numbers divisible by\nboth 3 and 5 with the word FizzBuzz, numbers divisible by both 3 and 7 with the word FizzPop, numbers divisible by both 5 and 7 with the word BuzzPop, and\nnumbers divisible by 3, 5, and 7 with FizzBuzzPop. Press enter to see the list.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nI hope that you enjoyed my FizzBuzzPop program and looking over the list. Have agreat day. Press enter to continue.");
        }
    }
}
