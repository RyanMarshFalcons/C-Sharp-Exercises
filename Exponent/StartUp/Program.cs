using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exponent;
using Exponent_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var Base = utility.GetValidEntry("base");
            var Exponent = utility.GetValidEntry("exponent");
            var Product = utility.GetProduct(Base, Exponent);
            Message.DisplayResults(Base, Exponent, Product);
            Console.ReadLine();
        }
    }
}
