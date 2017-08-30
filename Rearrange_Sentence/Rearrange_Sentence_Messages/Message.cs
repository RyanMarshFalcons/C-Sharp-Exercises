using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Sentence_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Random Concatenation program where you will enter a\nsentence and then I will create a new sentence for you out of the words in your sentence in a random order. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter a sentence: ");
        }

        public static void NotLongEnough()
        {
            Console.Write("\nYou must enter at least ten characters for your string to be valid. Please entera sentence: ");
        }

        public static void DisplayNewSentence(string newString)
        {
            Console.WriteLine($"\nAfter rearranging the words in your sentence your new sentence is:\n{newString}\nPress enter to close the program.");
        }
    }
}
