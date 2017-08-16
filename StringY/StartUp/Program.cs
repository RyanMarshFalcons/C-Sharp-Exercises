using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringY;
using StringY_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var isStringY = utility.CheckIfStringY(userString);
            utility.DisplayResults(isStringY);
            Console.ReadLine();
        }
    }
}
