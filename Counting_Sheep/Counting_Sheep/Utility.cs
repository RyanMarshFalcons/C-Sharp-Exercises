using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting_Sheep_Messages;
using System.Text.RegularExpressions;

namespace Counting_Sheep
{
    public enum Delay { Half_Second, One_Second, One_And_A_Half_Seconds, Two_Seconds, Two_And_A_Half_Seconds, Three_Seconds, Three_And_A_Half_Seconds, Four_Seconds, Four_And_A_Half_Seconds, Five_Seconds };
    public class Utility
    {
        public string GetValidDelaySelection()
        {
            Message.SelectFrequency();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "^[A-J() ]+$") && input.Length == 1;
        }

        public Delay ConvertLetterToDelay(string delayLetterSelection)
        {
            switch (delayLetterSelection)
            {
                case "A":
                    return Delay.Half_Second;
                    break;
                case "B":
                    return Delay.One_Second;
                    break;
                case "C":
                    return Delay.One_And_A_Half_Seconds;
                    break;
                case "D":
                    return Delay.Two_Seconds;
                    break;
                case "E":
                    return Delay.Two_And_A_Half_Seconds;
                    break;
                case "F":
                    return Delay.Three_Seconds;
                    break;
                case "G":
                    return Delay.Three_And_A_Half_Seconds;
                    break;
                case "H":
                    return Delay.Four_Seconds;
                    break;
                case "I":
                    return Delay.Four_And_A_Half_Seconds;
                    break;
                case "J":
                default:
                    return Delay.Five_Seconds;
                    break;
            }
        }

        public int GetMillisecondDelayAsInt(Delay delay)
        {
            switch (delay)
            {
                case Delay.Half_Second:
                    return 500;
                    break;
                case Delay.One_Second:
                    return 1000;
                    break;
                case Delay.One_And_A_Half_Seconds:
                    return 1500;
                    break;
                case Delay.Two_Seconds:
                    return 2000;
                    break;
                case Delay.Two_And_A_Half_Seconds:
                    return 2500;
                    break;
                case Delay.Three_Seconds:
                    return 3000;
                    break;
                case Delay.Three_And_A_Half_Seconds:
                    return 3500;
                    break;
                case Delay.Four_Seconds:
                    return 4000;
                    break;
                case Delay.Four_And_A_Half_Seconds:
                    return 4500;
                    break;
                case Delay.Five_Seconds:
                default:
                    return 5000;
                    break;
            }
        }

        public string GetName()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserName();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.NameTooShort();
                }
                else
                {
                    validEntry = true;
                }
            }
            return userInput;
        }

        public bool CheckIfTooShort(string input)
        {
            return input.Length < 1;
        }

        public void RandomMessage(string userName)
        {
            var random = new Random();
            var messageSelection = 0;
            messageSelection = random.Next(1, 6);
            switch (messageSelection)
            {
                case 1:
                    Message.GettingSleepy(userName);
                    break;
                case 2:
                    Message.DriftToSlumberland(userName);
                    break;
                case 3:
                    Message.CoolKids(userName);
                    break;
                case 4:
                    Message.BigDay(userName);
                    break;
                case 5:
                default:
                    Message.FunTimes(userName);
                    break;
            }
        }
    }
}
