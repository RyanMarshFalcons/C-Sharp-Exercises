using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consonant_Count;
using Consonant_Count_Messages;

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
            var consonantCount = utility.CountConsonantsInArray(inputArr);
            Message.DisplayCount(consonantCount);
            Console.ReadLine();
        }
    }
}
