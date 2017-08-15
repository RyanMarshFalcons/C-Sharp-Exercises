using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Character;
using Remove_Character_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var index = utility.GetIndex(userString.Length);
            var newString = utility.GetNewString(userString, index);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
