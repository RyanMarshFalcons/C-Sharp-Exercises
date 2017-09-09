using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word_Sorter;
using Word_Sorter_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetUserString();
            var modifiedUserString = utility.RemoveNumsAndSymbols(userString);
            var wordList = utility.ExtractWords(modifiedUserString);
            wordList = utility.SortTheWords(wordList);
            var counter = wordList.Count;
            utility.DisplaySortedWords(wordList, counter);
            Message.ThankYou();
        }
    }
}
