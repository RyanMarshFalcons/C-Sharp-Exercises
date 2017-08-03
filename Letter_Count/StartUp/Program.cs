using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letter_Count;
using Letter_Count_Messages;

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
            var letterCount = utility.CountLettersInArray(inputArr);
            Message.DisplayCount(letterCount);
            Console.ReadLine();
        }
    }
}
