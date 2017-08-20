using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_4;
using Left_To_End_4_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.CreateNewString(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
