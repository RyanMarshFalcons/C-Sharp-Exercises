using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey_Trouble;
using Monkey_Trouble_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var monkey1Smiling = utility.AskIfSmiling("first");
            var monkey2Smiling = utility.AskIfSmiling("second");
            var areInTrouble = utility.AreInTrouble(monkey1Smiling, monkey2Smiling);
            utility.DisplayResults(areInTrouble);
            Console.ReadLine();
        }
    }
}
