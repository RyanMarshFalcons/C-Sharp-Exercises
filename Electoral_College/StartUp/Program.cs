using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electoral_College;
using Electoral_College_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var myVotes = new List<int>();
            var userVotes = new List<int>();
            var winner = 0;
            var statesAndVotes = utility.VotesPerState();
            foreach (var entry in statesAndVotes)
            {
                winner = utility.GetValidEntry(entry.Key, entry.Value);
                if (winner == 1)
                {
                    userVotes.Add(entry.Value);
                }
                else
                {
                    myVotes.Add(entry.Value);
                }
            }
            var myTotalVotes = utility.SumOfVotes(myVotes);
            var userTotalVotes = utility.SumOfVotes(userVotes);
            utility.DisplayResults(myTotalVotes, userTotalVotes, myVotes.Count, userVotes.Count);
            Console.ReadLine();
        }
    }
}
