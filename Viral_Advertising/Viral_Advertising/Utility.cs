using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viral_Advertising_Messages;

namespace Viral_Advertising
{
    public class Utility
    {
        public int GetInitialNumberOfPeople()
        {
            Message.EnterNumberOfPeople();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NumberOfPeopleNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastFour(input))
                    {
                        Message.NumberOfPeopleMustBeAtLeastFour();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetNumberOfDays()
        {
            Message.EnterNumberOfDays();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NumberOfDaysNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastTwo(input))
                    {
                        Message.NumberOfDaysMustBeAtLeastTwo();
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

        public bool CheckIfAtLeastTwo(string input)
        {
            return int.Parse(input) >= 2;
        }

        public bool CheckIfAtLeastFour(string input)
        {
            return int.Parse(input) >= 4;
        }

        public int CaluclateTotalLikes(int initialNumPeople, int numDays)
        {
            var peopleThatSeeTheVideo = initialNumPeople;
            var totalLikes = 0;
            for (int i = 0; i < numDays; i++)
            {
                peopleThatSeeTheVideo /= 2;
                totalLikes += peopleThatSeeTheVideo;
                peopleThatSeeTheVideo *= 3;
            }
            return totalLikes;
        }
    }
}
