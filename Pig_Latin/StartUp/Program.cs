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
            var input = utility.GetValidEntry();
            var inputAsArray = utility.ConvertToCharArray(input);
            var inputAsPigLatin = "";
            if (utility.CheckIfBeginsWithVowel(inputAsArray) == true)
            {
                inputAsPigLatin = utility.AddYayToTheEnd(inputAsArray);
            }
            else
            {
                inputAsPigLatin = utility.MoveConsonantsToTheEnd(inputAsArray);
                inputAsPigLatin = utility.AddAyToTheEnd(inputAsPigLatin);
            }
            Message.DisplayInPigLatin(input, inputAsPigLatin);
            Console.ReadLine();
        }
    }
}
