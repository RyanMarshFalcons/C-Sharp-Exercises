using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breaking_The_Records_Messages;

namespace Breaking_The_Records
{
    public class Utility
    {
        public int GetNumGamesInSeason()
        {
            Message.AskNumberOfGames();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NumberOfGamesIsNotANumber(input);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetPointsScored(int gameNumber)
        {
            Message.AskNumberOfPoints(gameNumber);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NumberOfPointsIsNotANumber(input, gameNumber);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CannotBeNegative(gameNumber);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public int[] CalculateTheRecords(int[] pointsScoredEachGame)
        {
            var leastPointsRecord = pointsScoredEachGame[0];
            var mostPointsRecord = pointsScoredEachGame[0];
            var leastPointsRecordBrokenCounter = 0;
            var mostPointsRecordBrokenCounter = 0;
            for (int i = 1; i < pointsScoredEachGame.Length; i++)
            {
                if (pointsScoredEachGame[i] < leastPointsRecord)
                {
                    leastPointsRecord = pointsScoredEachGame[i];
                    leastPointsRecordBrokenCounter++;
                }
                if (pointsScoredEachGame[i] > mostPointsRecord)
                {
                    mostPointsRecord = pointsScoredEachGame[i];
                    mostPointsRecordBrokenCounter++;
                }
            }
            return new int[] { leastPointsRecordBrokenCounter, mostPointsRecordBrokenCounter };
        }
    }
}
