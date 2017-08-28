using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triple_Count;
using Triple_Count_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var tripleCount = utility.CountTriples(userString);
            utility.DisplayResults(tripleCount);
            Console.ReadLine();
        }
    }
}
