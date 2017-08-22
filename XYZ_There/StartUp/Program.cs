using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ_There;
using XYZ_There_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var xyzCount = utility.GetCount(userString, "xyz");
            var XYZCount = utility.GetCount(userString, "XYZ");
            Message.DisplayResult(xyzCount, XYZCount);
            Console.ReadLine();
        }
    }
}
