using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Del_del;
using Del_del_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var index = utility.FindIndex(userString);
            if (index == -1)
            {
                Message.StringUnchanged(userString);
            }
            else
            {
                var newString = utility.DeleteFromdelDelOnward(userString, index);
                Message.DisplayNewString(newString, userString.Length - index);
            }
            Console.ReadLine();
        }
    }
}
