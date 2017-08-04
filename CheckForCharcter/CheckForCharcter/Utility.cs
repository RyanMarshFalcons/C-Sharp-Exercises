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
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public char GetSpecificChar()
        {
            var input = "";
            Message.RequestCharacter();
            while (input.Length !=1)
            {
                input = Console.ReadLine();
                if (input.Length != 1)
                {
                    Message.NotASingleCharacter(input);
                }
            }
            return Char.Parse(input);
        }

        public int SearchForCharacter(string text, char character)
        {
            var count = 0;
            var arrInput = text.ToCharArray();
            for (int i = 0; i < arrInput.Count(); i++)
            {
                if (arrInput[i] == character)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
