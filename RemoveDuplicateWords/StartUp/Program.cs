using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateWords;
using RemoveDuplicateWords_Messages;

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
            var continueAsking = true;
            while (continueAsking == true)
            {
                word = utility.GetValidEntry();
                wordList.Add(word);
                continueAsking = utility.AskToContinue();
            }
            var newList = utility.RemoveDuplicates(wordList);
            utility.DisplayNewList(newList, wordList.Count - newList.Count);
            Console.ReadLine();
        }
    }
}
