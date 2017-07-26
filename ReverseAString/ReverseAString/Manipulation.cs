using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    public class Manipulation
    {
        public string inputInReverse(string userInput)
        {
            var userInputAsArray = userInput.ToCharArray();
            Array.Reverse(userInputAsArray);
            return new string (userInputAsArray);
        }
    }
}
