using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci_Sequence_Messages;

namespace Fibonacci_Sequence
{
    public class Utility
    {
        public int GetNextNumber(List<int> listOfNums)
        {
            return listOfNums[listOfNums.Count - 1] + listOfNums[listOfNums.Count - 2];
        }
    }
}
