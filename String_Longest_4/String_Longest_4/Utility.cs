using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Longest_4_Messages;

namespace String_Longest_4
{
    public class Utility
    {
        public string GetString(int entryNum)
        {
            var userInput = "";
            Message.EnterString(entryNum);
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings(entryNum);
                }
            }
            return userInput;
        }

        public int GetLongestLength(int[] lengths)
        {
            int max = Math.Max(lengths[0], lengths[1]);
            for (int i = 2; i < lengths.Length; i++)
            {
                max = Math.Max(max, lengths[i]);
            }
            return max;
        }
    }
}
