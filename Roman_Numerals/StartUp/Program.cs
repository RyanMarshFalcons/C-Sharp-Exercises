using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman_Numerals;
using Roman_Numerals_Messages;

namespace StartUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var ArabicNumber = utility.GetValidArabicNumber();
            var RomanNumeral = utility.BuildRomanNumeral(ArabicNumber);
            Message.DisplayResults(ArabicNumber, RomanNumeral);
            Console.ReadLine();
        }
    }
}
