using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MN_Balance;
using MN_Balance_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var mCount = utility.GetCount(userString, "m");
            var MCount = utility.GetCount(userString, "M");
            var nCount = utility.GetCount(userString, "n");
            var NCount = utility.GetCount(userString, "N");
            if (utility.CheckIfBalance(mCount, MCount, nCount, NCount))
            {
                Message.WasMNalance();
            }
            else
            {
                Message.WasNotMNalance();
            }
            Console.ReadLine();
        }
    }
}
