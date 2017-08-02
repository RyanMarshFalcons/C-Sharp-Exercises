using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FahrenheitToCelsius;
using FahrenheitToCelsius_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var fahrenheit = utility.GetValidEntry();
            var celsius = utility.GetCelsius(fahrenheit);
            Message.DisplayCelsius(fahrenheit, celsius);
            Console.ReadLine();
        }
    }
}
