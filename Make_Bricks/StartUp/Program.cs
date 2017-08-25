using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_Bricks;
using Make_Bricks_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var rowLength = utility.GetValidLength();
            var numSmall = utility.GetNumBricks("small");
            var numMedium = utility.GetNumBricks("medium");
            var numLarge = utility.GetNumBricks("large");
            var isPossible = utility.CheckIfPossible(rowLength, numSmall, numMedium, numLarge);
            utility.DisplayResults(isPossible, rowLength);
            Console.ReadLine();
        }
    }
}
