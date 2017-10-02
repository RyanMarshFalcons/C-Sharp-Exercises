using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Sock Merchant program where you have a clothing store with a pile of loose socks. You want to sell as many socks as possible but customers will\nonly buy them in matching pairs so lets find out how many matching pairs of\nsocks you have. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectColorOfSock(int sockNumber)
        {
            Console.WriteLine($"\nYou remove a sock from the pile. What color is sock number {sockNumber}:\nA) Green\nB) Red\nC) Blue\nD) Orange\nE) White\nF) Black\nG) Purple\nH) Pink\nI) Yellow\nJ) Brown");
        }

        public static void NotAValidSelection(string input, int sockNumber)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. What color is sock\nnumber {sockNumber}:\nA) Green\nB) Red\nC) Blue\nD) Orange\nE) White\nF) Black\nG) Purple\nH) Pink\nI) Yellow\nJ) Brown");
        }

        public static void AskToSortAnotherSock()
        {
            Console.Write("\nAre there any more socks in the pile that you haven't removed to be sorted yet? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Are there any more socks in the pile that you haven't removed to sort yet? y/n: ");
        }

        public static void NoMatchingPairs(int numTotalSocks)
        {
            Console.WriteLine($"\nUnfortunately, after sorting through all {numTotalSocks} loose socks no matching pairs\ncould be found. Press enter to continue.");
            Console.ReadLine();
        }

        public static void DisplayMatchingPairs(int numPairsMatchingSocks)
        {
            Console.WriteLine($"\nCongratulations you have {numPairsMatchingSocks} pairs of matching socks!!! They are displayed below:");
        }

        public static void NoLeftOverSocks(int numTotalSocks)
        {
            Console.WriteLine($"Congratulations all {numTotalSocks} of your socks were able to be matched together and you\nhave none left over!!! Press enter to close the program.");
        }

        public static void DisplayLeftOverSocks(int numLeftOverSocks)
        {
            Console.WriteLine($"The following {numLeftOverSocks} socks were unable to be paired:");
        }
    }
}
