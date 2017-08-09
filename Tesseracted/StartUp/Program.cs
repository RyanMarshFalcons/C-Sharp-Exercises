using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseracted;
using Tesseracted_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var numTesseracted = utility.GetNumberTesseracted(input);
            Message.NumberTesseracted(input, numTesseracted);
            Console.ReadLine();
        }
    }
}
