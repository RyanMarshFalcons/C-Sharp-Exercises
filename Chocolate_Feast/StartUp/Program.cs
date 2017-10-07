using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chocolate_Feast;
using Chocolate_Feast_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var priceOfChocolateBar = utility.GetPriceOfChocolateBar();
            var numDollars = utility.GetNumberOfDollars(priceOfChocolateBar);
            var numWrappersForFreeChocolate = utility.GetWrapperExchangeRate();
            var chocolatesEaten = utility.CalculateChocolatesEaten(numDollars, priceOfChocolateBar, numWrappersForFreeChocolate);
            Message.DisplayResults(chocolatesEaten);
            Console.ReadLine();
        }
    }
}
