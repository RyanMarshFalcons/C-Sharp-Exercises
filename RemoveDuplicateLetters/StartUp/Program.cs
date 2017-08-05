using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateLetters;
using RemoveDuplicateLetters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var letterList = new List<char>();
            var letter = ' ';
            var continueAsking = true;
            while (continueAsking == true)
            {
                letter = utility.GetValidEntry();
                letterList.Add(letter);
                continueAsking = utility.AskToContinue();
            }
            var newList = utility.RemoveDuplicates(letterList);
            utility.DisplayNewList(newList, letterList.Count - newList.Count);
            Console.ReadLine();
        }
    }
}
