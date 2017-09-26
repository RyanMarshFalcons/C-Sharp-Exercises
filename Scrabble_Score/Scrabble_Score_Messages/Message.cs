using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble_Score_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Scrabble Score program where you will input a word and any specialsquares that any of the letters of your word fall on and I will calculate the\nscore of your word for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please enter your scrabble word: ");
        }

        public static void ContainsNonLetters()
        {
            Console.Write("\nSorry but scrabble words can only contain letters. Please enter your scrabble\nword: ");
        }

        public static void TooShort()
        {
            Console.Write("\nSorry but you must input at least one letter. Please enter your scrabble\nword: ");
        }

        public static void TooLong()
        {
            Console.Write("\nSorry but a Scrabble board can only fit words up to fifteen letters long. Pleaseenter your scrabble word: ");
        }

        public static void AskSquareType(char letter)
        {
            Console.WriteLine($"\nIs {letter} on a:\nA) Regular Square\nB) Double Letter Square\nC) Triple Letter Square\nD) Double Word Square\nE) Triple Word Square");
        }

        public static void NotAValidSelection(string input, char letter)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Is {letter} on a:\nA) Regular Square\nB) Double Letter Square\nC) Triple Letter Square\nD) Double Word Square\nE) Triple Word Square");
        }

        public static void DisplayWordScore(string userWord, int wordScore)
        {
            Console.WriteLine($"\nYour score for the word {userWord} is {wordScore} points.\nPress enter to close the program.");
        }
    }
}
