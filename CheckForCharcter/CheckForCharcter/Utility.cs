using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckForCharacter_Messages;

namespace CheckForCharcter
{
    public class Utility
    {
        public string GetUserInput()
        {
            var userInput = "";
            Message.RequestUserInput();
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public char GetSpecificChar()
        {
            var input = "";
            var validInput = false;
            Message.RequestCharacter();
            while (validInput == false)
            {
                input = Console.ReadLine();
                if (IsASingleCharacter(input) == false)
                {
                    Message.NotASingleCharacter(input);
                }
                else
                {
                    validInput = true;
                }
            }
            return Char.Parse(input);
        }

        public bool IsASingleCharacter(string input)
        {
            return input.Length == 1;
        }

        public int SearchForCharacter(string text, char character)
        {
            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
