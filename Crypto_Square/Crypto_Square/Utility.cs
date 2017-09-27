using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto_Square_Messages;

namespace Crypto_Square
{
    public class Utility
    {
        public string GetValidMessage()
        {
            var userInput = "";
            var validEntry = false;
            Message.RequestUserString();
            while (!validEntry)
            {
                userInput = Console.ReadLine();
                if (CheckIfTooShort(userInput))
                {
                    Message.TooShort();
                }
                else if (CheckIfContainsAnyLetters(userInput) == false)
                {
                    Message.HasNoLetters();
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
            return input.Length < 4;
        }

        public bool CheckIfContainsAnyLetters(string input)
        {
            return input.Any(x => char.IsLetter(x));
        }

        public string NormalizeText(string userMessage)
        {
            return string.Concat(userMessage.Where(c => char.IsLetterOrDigit(c))).ToLower();
        }

        public int GetWidth(string normalizedMessage)
        {
            return (int)Math.Ceiling(Math.Sqrt(normalizedMessage.Length));
        }

        public List<string> ConstructRows(string normalizedMessage, int width)
        {
            var rowsOfText = new List<string>();
            while (normalizedMessage.Length > width)
            {
                rowsOfText.Add(normalizedMessage.Substring(0, width));
                normalizedMessage = normalizedMessage.Substring(width);
            }
            if (normalizedMessage.Length > 0)
            {
                rowsOfText.Add(normalizedMessage);
            }
            return rowsOfText;
        }
    }
}
