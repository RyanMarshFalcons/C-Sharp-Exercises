using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringSum_Messages;

namespace StringSum
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

        public List<int> ExtractNumberCharacters(string input)
        {
            var justNums = input.Where(c => Char.IsDigit(c)).ToArray();
            var numList = new List<int>();
            for (int i = 0; i < justNums.Count(); i++)
            {
                    numList.Add(int.Parse(justNums[i].ToString()));
            }
            return numList;
        }

        public int GetSum(List<int> numList)
        {
            return numList.Sum();
        }
    }
}
