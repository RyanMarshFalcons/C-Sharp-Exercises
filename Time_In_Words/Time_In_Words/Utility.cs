using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_In_Words_Messages;

namespace Time_In_Words
{
    public enum SpecialTime { On_The_Hour, One_Minute_Past, Quarter_Past, Half_Past, Quarter_To, One_Minute_To, Regular};
    public class Utility
    {
        public string[] GetTimeAsNumerals()
        {
            var input = "";
            Message.EnterTimeInNumerals();
            var validInput = false;
            while (validInput == false)
            {
                input = Console.ReadLine();
                if (!CheckIfValidFormat(input))
                {
                    Message.TimeEnteredInIncorrectFormat();
                }
                else
                {
                    if (!CheckIfValidTime(input))
                    {
                        Message.TimeEnteredIsInvalid();
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return input.Split(':', ' ');
        }

        public bool CheckIfValidFormat(string input)
        {
            var inputSplit = input.Split(':', ' ');
            var n = 0;
            return inputSplit.Length == 2 && int.TryParse(inputSplit[0], out n) && int.TryParse(inputSplit[1], out n);
        }

        public bool CheckIfValidTime(string input)
        {
            var inputSplit = input.Split(':', ' ');
            return int.Parse(inputSplit[0]) >= 1 && int.Parse(inputSplit[0]) <= 12 && int.Parse(inputSplit[1]) >= 0 && int.Parse(inputSplit[1]) <= 59;
        }

        public SpecialTime DetermineTimeVariant(int minutes)
        {
            switch (minutes)
            {
                case 0:
                    return SpecialTime.On_The_Hour;
                    break;
                case 1:
                    return SpecialTime.One_Minute_Past;
                    break;
                case 15:
                    return SpecialTime.Quarter_Past;
                    break;
                case 30:
                    return SpecialTime.Half_Past;
                    break;
                case 45:
                    return SpecialTime.Quarter_To;
                    break;
                case 59:
                    return SpecialTime.One_Minute_To;
                    break;
                default:
                    return SpecialTime.Regular;
                    break;
            }
        }

        public string CalculateTimeInWords(int minutes, int hours, SpecialTime timeVariant)
        {
            var numeralToWord = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {16, "sixteen" },
                {17, "seventeen" },
                {18, "eighteen" },
                {19, "nineteen" },
                {20, "twenty" },
                {21, "twenty-one" },
                {22, "twenty-two" },
                {23, "twenty-three" },
                {24, "twenty-four" },
                {25, "twenty-five" },
                {26, "twenty-six" },
                {27, "twenty-seven" },
                {28, "twenty-eight" },
                {29, "twenty-nine" }
            };

            switch (timeVariant)
            {
                case SpecialTime.On_The_Hour:
                    return numeralToWord[hours] + " o'clock";
                    break;
                case SpecialTime.One_Minute_Past:
                    return "one minute past " + numeralToWord[hours];
                    break;
                case SpecialTime.Quarter_Past:
                    return "quarter past " + numeralToWord[hours];
                    break;
                case SpecialTime.Half_Past:
                    return "half past " + numeralToWord[hours];
                    break;
                case SpecialTime.Quarter_To:
                    if (hours == 12)
                    {
                        return "quarter to one";
                    }
                    else
                    {
                        return "quarter to " + numeralToWord[hours + 1];
                    }
                    break;
                case SpecialTime.One_Minute_To:
                    if (hours == 12)
                    {
                        return "one minute to one";
                    }
                    else
                    {
                        return "one minute to " + numeralToWord[hours + 1];
                    }
                    break;
                case SpecialTime.Regular:
                default:
                    if (minutes < 30)
                    {
                        return numeralToWord[minutes] + " minutes past " + numeralToWord[hours];
                    }
                    else
                    {
                        if (hours == 12)
                        {
                            return numeralToWord[60 - minutes] + " minutes to one";
                        }
                        else
                        {
                            return numeralToWord[60 - minutes] + " minutes to " + numeralToWord[hours + 1];
                        }
                    }
                    break;
            }
        }
    }
}
