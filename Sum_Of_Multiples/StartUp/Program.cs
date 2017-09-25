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
            var allMultiples = utility.GetAllMultiples(listOfNums, ceilingNumber);
            var uniqueMultiples = utility.GetUniqueMultiples(allMultiples);
            uniqueMultiples.Sort();
            var sum = utility.CalculateSumOfMultiples(uniqueMultiples, ceilingNumber);
            Message.DisplaySum(ceilingNumber, sum, uniqueMultiples);
            Console.ReadLine();
        }
    }
}
