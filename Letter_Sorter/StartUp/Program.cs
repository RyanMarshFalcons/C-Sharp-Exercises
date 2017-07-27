using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letter_Sorter;
using Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var letterList = new List<char>();
            var letter = 'a';
            var counter = 0;
            var continueAsking = true;
            while (continueAsking == true)
            {
                letter = utility.GetValidEntry();
                letterList.Add(letter);
                continueAsking = utility.AskToContinue();
                counter += 1;
            }
            letterList = utility.SortTheLetters(letterList);
            utility.DisplaySortedLetters(letterList, counter);
            Console.ReadLine();
        }
    }
}
