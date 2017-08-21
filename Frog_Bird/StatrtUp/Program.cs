using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frog_Bird;
using Frog_Bird_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var frogCount = utility.GetCount(userString, "frog");
            var birdCount = utility.GetCount(userString, "bird");
            Message.DisplayResult(frogCount, birdCount);
            Console.ReadLine();
        }
    }
}
