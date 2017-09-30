using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breaking_The_Records;
using Breaking_The_Records_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numGamesInSeason = utility.GetNumGamesInSeason();
            var pointsScoredEachGame = new int[numGamesInSeason];
            for (int i = 0; i < numGamesInSeason; i++)
            {
                pointsScoredEachGame[i] = utility.GetPointsScored(i + 1);
            }
            var timesRecordsBroken = utility.CalculateTheRecords(pointsScoredEachGame);
            Message.DisplayResults(numGamesInSeason, timesRecordsBroken[0], timesRecordsBroken[1]);
            Console.ReadLine();
        }
    }
}
