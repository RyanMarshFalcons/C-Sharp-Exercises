using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Around;
using Front_Around_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.AddFirstToFrontAndBack(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
