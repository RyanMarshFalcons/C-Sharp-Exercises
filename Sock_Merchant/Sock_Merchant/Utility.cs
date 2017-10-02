using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sock_Merchant_Messages;
using System.Text.RegularExpressions;

namespace Sock_Merchant
{
    public enum Color { Green, Red, Blue, Orange, White, Black, Purple, Pink, Yellow, Brown};
    public class Utility
    {
        public Color GetValidColorSelection(int sockNumber)
        {
            Message.SelectColorOfSock(sockNumber);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfValidSelection(input))
                {
                    Message.NotAValidSelection(input, sockNumber);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return ConvertLetterToColor(input);
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-J]") && input.Length == 1;
        }

        public Color ConvertLetterToColor(string letterSelected)
        {
            switch (letterSelected)
            {
                case "A":
                    return Color.Green;
                    break;
                case "B":
                    return Color.Red;
                    break;
                case "C":
                    return Color.Blue;
                    break;
                case "D":
                    return Color.Orange;
                    break;
                case "E":
                    return Color.White;
                    break;
                case "F":
                    return Color.Black;
                    break;
                case "G":
                    return Color.Purple;
                    break;
                case "H":
                    return Color.Pink;
                    break;
                case "I":
                    return Color.Yellow;
                    break;
                case "J":
                default:
                    return Color.Brown;
                    break;
            }
        }

        public bool AskToAddAnotherSock()
        {
            var IsValidInput = false;
            var input = "";
            Message.AskToSortAnotherSock();
            while (!IsValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfyOrn(input))
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public SockTracker GetMatchingPairs(List<Color> sockPile)
        {
            var sockTracker = new SockTracker();
            sockTracker.MatchingPairs = new List<Color>();
            sockTracker.UnmatchedSocks = new List<Color>();
            sockPile.Sort();
            while (sockPile.Count > 0)
            {
                if (sockPile.Count == 1)
                {
                    sockTracker.UnmatchedSocks.Add(sockPile[0]);
                }
                else
                {
                    if (sockPile[0] == sockPile[1])
                    {
                        sockTracker.MatchingPairs.Add(sockPile[0]);
                        sockPile.Remove(sockPile[1]);
                    }
                    else
                    {
                        sockTracker.UnmatchedSocks.Add(sockPile[0]);
                    }
                }
                sockPile.Remove(sockPile[0]);
            }
            return sockTracker;
        }

        public void DisplayResults(SockTracker sockTracker)
        {
            if (sockTracker.MatchingPairs.Count == 0)
            {
                Message.NoMatchingPairs(sockTracker.TotalNumberOfSocks());
            }
            else
            {
                Message.DisplayMatchingPairs(sockTracker.MatchingPairs.Count);
                foreach (var pair in sockTracker.MatchingPairs)
                {
                    Console.WriteLine($"Pair of {pair} socks");
                }
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
            }
            if (sockTracker.UnmatchedSocks.Count == 0)
            {
                Message.NoLeftOverSocks(sockTracker.TotalNumberOfSocks());
            }
            else
            {
                Message.DisplayLeftOverSocks(sockTracker.UnmatchedSocks.Count);
                foreach (var sock in sockTracker.UnmatchedSocks)
                {
                    Console.WriteLine($"One {sock} sock");
                }
                Console.WriteLine($"\nPress enter to close the program.");
            }
        }
    }
}
