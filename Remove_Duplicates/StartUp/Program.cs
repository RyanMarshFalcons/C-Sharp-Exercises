using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Duplicates;
using Remove_Duplicates_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetUserString();
            var selectionLetter = utility.GetValidSelection();
            var whatToRemove = utility.ConvertLetterToRemoveDupicate(selectionLetter);
            var newString = "";
            switch (whatToRemove)
            {
                case RemoveDuplicate.letters:
                    newString = utility.RemoveDuplicateLetters(userString);
                    break;
                case RemoveDuplicate.numbers:
                    newString = utility.RemoveDuplicateNumbers(userString);
                    break;
                case RemoveDuplicate.symbols:
                    newString = utility.RemoveDuplicateSymbols(userString);
                    break;
                default:
                    break;
            }
            Message.DisplayNewString(whatToRemove.ToString(), newString);
            Console.ReadLine();
        }
    }
}
