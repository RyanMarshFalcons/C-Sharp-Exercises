using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back_Around;
using Back_Around_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.AddLastToFrontAndBack(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
