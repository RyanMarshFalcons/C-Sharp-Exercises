using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grains;
using Grains_Messages;
    
namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numberOfSquares = utility.GetNumberOfSquares();
            var totalNumGrains = utility.CalculateGrains(numberOfSquares);
            var totalAsString = utility.AddCommasToNumber(totalNumGrains);
            Message.DisplayResults(numberOfSquares, totalAsString);
            Console.ReadLine();
        }
    }
}
