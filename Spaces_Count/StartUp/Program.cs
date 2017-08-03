using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spaces_Count;
using Spaces_Count_Messages;

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
            var spacesCount = utility.CountSpacesInArray(inputArr);
            Message.DisplayCount(spacesCount);
            Console.ReadLine();
        }
    }
}
