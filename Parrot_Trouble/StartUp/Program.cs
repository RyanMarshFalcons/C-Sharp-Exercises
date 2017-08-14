using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parrot_Trouble;
using Parrot_Trouble_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var isSleeping = utility.AskIfDoing("sleeping");
            var isStudying = utility.AskIfDoing("studying");
            var isMeditating = utility.AskIfDoing("meditating");
            var isCausingTrouble = utility.CheckIfCausingTrouble(isSleeping, isStudying, isMeditating);
            utility.DisplayResults(isCausingTrouble);
            Console.ReadLine();
        }
    }
}
