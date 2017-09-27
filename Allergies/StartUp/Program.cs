using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allergies;
using Allergies_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utiltiy = new Utility();
            var allergyScore = utiltiy.GetValidAllergyScore();
            var listOfAllergies = utiltiy.DetermineListOfAllergies(allergyScore);
            Message.DisplayListOfAllergies(listOfAllergies);
            Console.ReadLine();
        }
    }
}
