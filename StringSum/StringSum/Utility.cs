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
            var arrInput = input.ToCharArray();
            var numList = new List<int>();
            for (int i = 0; i < arrInput.Count(); i++)
            {
                if (Char.IsNumber(arrInput[i]))
                {
                    numList.Add(Int32.Parse(arrInput[i].ToString()));
                }
            }
            return numList;
        }

        public int GetSum(List<int> numList)
        {
            var sum = 0;
            foreach (var num in numList)
            {
                sum += num;
            }
            return sum;
        }
    }
}
