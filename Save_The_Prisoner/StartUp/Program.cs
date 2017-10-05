using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Save_The_Prisoner;
using Save_The_Prisoner_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numberOfPrisoners = utility.GetNumberOfPrisoners();
            var IDOfPrisonerWhoGetsFirstSweet = utility.GetIDOfPrisonerGettingFirstSweet(numberOfPrisoners);
            var numberOfSweets = utility.GetNumberOfSweets();
            var IDOfPrisonerToWarn = utility.CalculateIDOfPrisonerToWarn(numberOfPrisoners, IDOfPrisonerWhoGetsFirstSweet, numberOfSweets);
            Message.DisplayResult(IDOfPrisonerToWarn);
            Console.ReadLine();
        }
    }
}
