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
        public static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var myVotes = new List<int>();
            var userVotes = new List<int>();
            var winnerOfStateAsNum = 0;
            var winnerOfState = new WinnerOfState();
            var statesAndVotes = utility.VotesPerState();
            foreach (var entry in statesAndVotes)
            {
                winnerOfStateAsNum = utility.GetValidEntry(entry.Key, entry.Value);
                winnerOfState = utility.NumSelectionToEnum(winnerOfStateAsNum);
                if (winnerOfState == WinnerOfState.User)
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
            var electionResult = utility.DetermineResultOfElection(myTotalVotes, userTotalVotes);
            utility.DisplayResults(electionResult, myVotes.Count, userVotes.Count, myTotalVotes, userTotalVotes);
            Console.ReadLine();
        }
    }
}
