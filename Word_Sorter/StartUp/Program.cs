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
            var wordList = new List<string>();
            var word = "";
            var counter = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                word = utility.GetValidEntry();
                wordList.Add(word);
                continueAsking = utility.AskToContinue();
                counter += 1;
            }
            wordList = utility.SortTheWords(wordList);
            utility.DisplaySortedWords(wordList, counter);
            Console.ReadLine();
        }
    }
}
