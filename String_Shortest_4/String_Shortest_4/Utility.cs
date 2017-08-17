using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Shortest_4_Messages;

namespace String_Shortest_4
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

        public int GetShortestLength(int[] lengths)
        {
            int min = Math.Min(lengths[0], lengths[1]);
            for (int i = 2; i < lengths.Length; i++)
            {
                min = Math.Min(min, lengths[i]);
            }
            return min;
        }
    }
}
