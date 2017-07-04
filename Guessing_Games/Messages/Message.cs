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
            Console.WriteLine("Hello and welcome to Ryan's Guessing Games. Please select which game that you \nwould like to play today:");
            Console.WriteLine("1: Flip A Coin \n2: Rock Paper Scissors \n3: Pick A Number \n4: Skittles Colors \n5: Days Of The Week");
        }

        public static void InvalidInput()
        {
            Console.WriteLine("I'm sorry the selection that you've made is invalid. Please try again.");
        }

        public static void SelectCoinSide()
        {
            Console.WriteLine("\nI flip a coin in the air. Call heads or tails: \n1: Heads \n2: Tails");
        }

        public static void SelectThrow()
        {
            Console.WriteLine("\nOn three rock paper scissors go!!! What would you like to throw: \n1: Rock \n2: Paper \n3: Scissors");
        }

        public static void WonGame(string userSelection, string houseSelection, string explanation)
        {
            Console.WriteLine($"\nCongragulations you are a winner!!!!! \nYou chose {userSelection} {explanation} {houseSelection}.");
        }

        public static void LostGame(string userSelection, string houseSelection, string explanation)
        {
            Console.WriteLine($"\nThe house wins. You chose {userSelection} {explanation} {houseSelection}.");
        }

        public static void TiedGame(string userSelection, string houseSelection, string explanation)
        {
            Console.WriteLine($"\nThe match is a draw. You chose {userSelection} {explanation} {houseSelection}.");
        }

        public static void SelectNumber(string guessNumber)
        {
            Console.WriteLine($"\nI'm thinking of a number between 1 and 10. Can you guess what the number is in \nthree guesses? What is your {guessNumber} guess: \n1: 1 \n2: 2 \n3: 3 \n4: 4 \n5: 5 \n6: 6 \n7: 7 \n8: 8 \n9: 9 \n10: 10");
        }
        
        public static void Higher(string userGuess)
        {
            Console.WriteLine($"\nNope too high. The number I'm thinking of is lower than {userGuess}.");
        }

        public static void Lower(string userGuess)
        {
            Console.WriteLine($"\nNope too low. The number I'm thinking of is higher than {userGuess}.");
        }

        public static void SelectColor(string guessNumber)
        {
            Console.WriteLine($"\nI pick out a piece of Skittles candy from a bag. Can you guess what color it is in threee guesses? What is your {guessNumber} guess: \n1: red \n2: green \n3: orange \n4: yellow \n5: purple \n6: pink");
        }

        public static void IncorrectColor(string userGuess)
        {
            Console.WriteLine($"\nNope my Skittles candy isn't {userGuess}.");
        }

        public static void SelectDay(string guessNumber)
        {
            Console.WriteLine($"\nI'm thinking of a day of the week. Can you guess what day it is in three \nguesses? What is your {guessNumber} guess: \n1: Monday \n2: Tuesday \n3: Wednesday \n4: Thursday \n5: Friday \n6: Saturday \n7: Sunday");
        }

        public static void WayOff(string userGuess)
        {
            Console.WriteLine($"\nNope you're way off. The day that I'm thinking of isn't {userGuess} or directly\nbefore or after {userGuess}.");
        }

        public static void WithinADay(string userGuess)
        {
            Console.WriteLine($"\nYou're so close. The day that I'm thiking of isn't {userGuess} but it does come\neither directly before or after {userGuess}.");
        }
    }
}
