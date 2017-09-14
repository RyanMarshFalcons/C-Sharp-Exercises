using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum_Of_Multiples;
using Sum_Of_Multiples_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var ceilingNumber = utility.GetValidNumber("the ceiling");
            var num = 0;
            var listOfNums = new List<int>();
            do
            {
                num = utility.GetValidNumber("a");
                listOfNums.Add(num);
            } while (utility.AskToAddAnotherNumber());
            var completeListOfMultiples = new List<int>();
            var individualListOfMultiples = new List<int>();
            foreach (var userNumber in listOfNums)
            {
                individualListOfMultiples = utility.GetMultiples(userNumber, ceilingNumber);
                completeListOfMultiples = completeListOfMultiples.Concat(individualListOfMultiples).ToList();
            }
            var sum = utility.CalculateSumOfMultiples(completeListOfMultiples, ceilingNumber);
            Message.DisplaySum(ceilingNumber, sum);
            Console.ReadLine();
        }
    }
}
