using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoundsToKilograms;
using PoundsToKilograms_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var pounds = utility.GetValidEntry();
            var kilograms = utility.GetKilograms(pounds);
            Message.DisplayKilograms(pounds, kilograms);
            Console.ReadLine();
        }
    }
}
