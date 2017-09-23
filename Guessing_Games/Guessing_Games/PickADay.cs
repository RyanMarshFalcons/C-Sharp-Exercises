using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    public enum DayGuess { WayOff, WithinADay, Correct }
    public class PickADay
    {
        public Day ConvertToDay(int num)
        {
            switch (num)
            {
                case 1:
                    return Day.Monday;
                    break;
                case 2:
                    return Day.Tuesday;
                    break;
                case 3:
                    return Day.Wednesday;
                    break;
                case 4:
                    return Day.Thursday;
                    break;
                case 5:
                    return Day.Friday;
                    break;
                case 6:
                    return Day.Saturday;
                    break;
                case 7:
                default:
                    return Day.Sunday;
                    break;
            }
        }
        public DayGuess CompareDays(Day userGuess, Day actualDay)
        {
            if (userGuess == actualDay)
            {
                return DayGuess.Correct;
            }
            else if (((userGuess == Day.Monday) && ((actualDay == Day.Sunday) || (actualDay == Day.Tuesday))) || ((userGuess == Day.Tuesday) && ((actualDay == Day.Monday) || (actualDay == Day.Wednesday))) || ((userGuess == Day.Wednesday) && ((actualDay == Day.Tuesday) || (actualDay == Day.Thursday))) || ((userGuess == Day.Thursday) && ((actualDay == Day.Wednesday) || (actualDay == Day.Friday))) || ((userGuess == Day.Friday) && ((actualDay == Day.Thursday) || (actualDay == Day.Saturday))) || ((userGuess == Day.Saturday) && ((actualDay == Day.Friday) || (actualDay == Day.Sunday))) || ((userGuess == Day.Sunday) && ((actualDay == Day.Saturday) || (actualDay == Day.Monday))))
            {
                Message.WithinADay(userGuess.ToString());
                return DayGuess.WithinADay;
            }
            else
            {
                Message.WayOff(userGuess.ToString());
                return DayGuess.WayOff;
            }
        }

        public Day MakeAGuess(string attempt)
        {
            var utility = new Utility();
            Message.SelectDay(attempt);
            var validNums = new int[] { 1, 2, 3, 4, 5, 6, 7};
            var userGuessAsString = utility.GetUserInput(validNums);
            var userGuessAsInt = utility.ConvertToNum(userGuessAsString);
            return ConvertToDay(userGuessAsInt);
        }

        public void DisplayResults(DayGuess gameResult, Day userGuess, Day actualDay)
        {
            if (gameResult == DayGuess.Correct)
            {
                Message.WonGame(userGuess.ToString(), actualDay.ToString(), "and the correct day was");
            }
            else
            {
                Message.LostGame(userGuess.ToString(), actualDay.ToString(), "and the actual day was");
            }
        }

    }
}
