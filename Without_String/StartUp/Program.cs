using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_String;
using Without_String_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var baseString = utility.GetString("base");
            var removeString = utility.GetString("remove");
            var newString = utility.RemoveInstancesFromBase(baseString, removeString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
