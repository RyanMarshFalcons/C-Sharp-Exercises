using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelsiusToFahrenheit;
using CelsiusToFahrenheit_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var celsius = utility.GetValidEntry();
            var fahrenheit = utility.GetFahrenheit(celsius);
            Message.DisplayFahrenheit(celsius, fahrenheit);
            Console.ReadLine();
        }
    }
}
