using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cat_Dog;
using Cat_Dog_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var catCount = utility.GetCount(userString, "cat");
            var dogCount = utility.GetCount(userString, "dog");
            Message.DisplayResult(catCount, dogCount);
            Console.ReadLine();
        }
    }
}
