using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Count;
using Number_Count_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var inputArr = utility.ConvertToCharArray(input);
            var numberCount = utility.CountNumbersInArray(inputArr);
            Message.DisplayCount(numberCount);
            Console.ReadLine();
        }
    }
}
