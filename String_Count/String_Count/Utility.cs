using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Count_Messages;

namespace String_Count
{
    public class Utility
    {
        public string GetValidString()
        {
            var userInput = "";
            Message.RequestUserInput();
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.TooShort();
                }
            }
            return userInput;
        }

        public bool IsTooShort(string userString)
        {
            return userString.Length < 1;
        }

        public int CountLettersInString(string userString)
        {
            return
                    (from c in userString
                     where Char.IsLetter(c)
                     select c).Count();
        }

        public int CountNumbersInString(string userString)
        {
            return
                    (from c in userString
                     where Char.IsNumber(c)
                     select c).Count();
        }

        public int CountSpacesInString(string userString)
        {
            return
                    (from c in userString
                     where c == ' '
                     select c).Count();
        }

        public int CountSymbolsInString(string userString)
        {
            return
                    (from c in userString
                     where (Char.IsLetterOrDigit(c) == false) && (c != ' ')
                     select c).Count();
        }
    }
}
