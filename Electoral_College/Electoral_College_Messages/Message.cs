using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electoral_College_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Electoral College program. You and I are both running\nfor President. The winner is the person who gets the most electoral votes. Let'ssee who wins. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWinner(string state, int votes)
        {
            Console.Write($"\n{state} has {votes} electoral votes. Which one of us won the state of\n{state}? Enter 1 for you or 2 for me: ");
        }

        public static void Not1or2(string state)
        {
            Console.Write($"\nSorry but you must enter either 1 or 2 for the winner of {state}.\nWhich one of us won {state}? Enter 1 for you or 2 for me: ");
        }

        public static void UserWon(int statesUserWon, int statesIWon, int userVotes, int myVotes)
        {
            Console.WriteLine($"\nCongratulations you won {statesUserWon} states worth {userVotes} electoral votes to my {statesIWon} states\nworth {myVotes} electoral votes and are the new President.");
        }

        public static void IWon(int statesUserWon, int statesIWon, int userVotes, int myVotes)
        {
            Console.WriteLine($"\nUnfortunately you only won {statesUserWon} states worth {userVotes} electoral votes to my {statesIWon} states\nworth {myVotes} elctoral votes so I am the new President.");
        }

        public static void Tie(int statesUserWon, int statesIWon, int userVotes, int myVotes)
        {
            Console.WriteLine($"\nYou won {statesUserWon} states worth {userVotes} electoral votes and I won {statesIWon} states worth\n{myVotes} electoral votes so the election is a tie. Its up to the House of Representatives\nin each state to determine the winner now.");
        }
    }
}
