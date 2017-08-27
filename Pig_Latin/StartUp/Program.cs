using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pig_Latin;
using Pig_Latin_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidEntry();
            var userStringAsPigLatin = "";
            if (utility.CheckIfBeginsWithVowel(userString) == true)
            {
                userStringAsPigLatin = utility.AddYayToTheEnd(userString);
            }
            else
            {
                userStringAsPigLatin = utility.MoveConsonantsToTheEnd(userString);
                userStringAsPigLatin = utility.AddAyToTheEnd(userStringAsPigLatin);
            }
            Message.DisplayInPigLatin(userString, userStringAsPigLatin);
            Console.ReadLine();
        }
    }
}
