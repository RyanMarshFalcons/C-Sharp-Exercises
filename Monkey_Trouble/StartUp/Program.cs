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
            Message.EnterIfSmiling("first");
            var monkey1Smiling = utility.AskQuestion();
            Message.EnterIfSmiling("second");
            var monkey2Smiling = utility.AskQuestion();
            Message.EnterIfwearingYellow();
            var wearingYellow = utility.AskQuestion();
            Message.EnterIfCaged();
            var caged = utility.AskQuestion();
            var monkeysSame = utility.AreMonkeysSame(monkey1Smiling, monkey2Smiling);
            var areInTrouble = utility.AreInTrouble(monkeysSame, wearingYellow, caged);
            utility.DisplayResults(areInTrouble);
            Console.ReadLine();
        }
    }
}
