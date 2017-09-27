using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allergies_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Allergies program where you will enter the score you\nrecieved on your allergy test and I will tell you all the things that your\nallergy score indicates that you are allergic to. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestAllergyScore()
        {
            Console.Write("Please enter the score that you recieved on your allergy test: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the score that you\nrecieved on your allergy test: ");
        }

        public static void ScoreCannotBeNegative()
        {
            Console.Write($"\nSorry but your allergy score cannot be negative. Please enter the score that yourecieved on your allergy test: ");
        }

        public static void ScoreCannotBeGreaterThan255()
        {
            Console.Write($"\nSorry but your allergy score cannot be greater than 255. Please enter the score that you recieved on your allergy test: ");
        }

        public static void DisplayListOfAllergies(List<string> listOfAllergies)
        {
            Console.WriteLine("\nAccording to your allergy score you are allergic to the following:");
            foreach (var allergy in listOfAllergies)
            {
                Console.WriteLine(allergy);
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Thank you for using my Allergies program. I hope that it was informative. Press enter to close the program.");
        }
    }
}
