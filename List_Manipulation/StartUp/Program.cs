using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List_Manipulation;
using List_Manipulation_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = "";
            var listOfUserStrings = new List<string>();
            var counter = 0;
            do
            {
                counter++;
                userString = utility.GetUserString(counter);
                listOfUserStrings.Add(userString);
            } while (utility.AskToAddAnotherString());
            Message.DisplayListOfUnmanipulatedStrings();
            foreach (var stringEntry in listOfUserStrings)
            {
                Console.WriteLine(stringEntry);
            }
            var manipulationSelectionLetter = utility.GetManipulationSelectionLetter();
            var manipulation = utility.ConvertLetterToManipulation(manipulationSelectionLetter);
            var listOfManipulatedUserStrings = new List<string>();
            switch (manipulation)
            {
                case Manipulation.Add_Letter_To_Beginning:
                    var letterToAddToBeginning = utility.GetLetter("beginning");
                    listOfManipulatedUserStrings = utility.AddToBeginning(listOfUserStrings, letterToAddToBeginning.ToString());
                    break;
                case Manipulation.Add_Letter_To_End:
                    var letterToAddToEnd = utility.GetLetter("end");
                    listOfManipulatedUserStrings = utility.AddToEnd(listOfUserStrings, letterToAddToEnd.ToString());
                    break;
                case Manipulation.Capitalize_Letters:
                    listOfManipulatedUserStrings = utility.CapitalizeLetters(listOfUserStrings);
                    break;
                case Manipulation.Delete_Short_Strings:
                    var minimumLength = utility.GetLength("minimum");
                    listOfManipulatedUserStrings = utility.RemoveShortStrings(listOfUserStrings, minimumLength);
                    break;
                case Manipulation.Delete_Long_Strings:
                    var maximumLength = utility.GetLength("maximum");
                    listOfManipulatedUserStrings = utility.RemoveLongStrings(listOfUserStrings, maximumLength);
                    break;
                case Manipulation.Add_Number_To_Beginning:
                    var numberToAddToBeginning = utility.GetNumber("beginning");
                    listOfManipulatedUserStrings = utility.AddToBeginning(listOfUserStrings, numberToAddToBeginning.ToString());
                    break;
                case Manipulation.Add_Number_To_End:
                    var numberToAddToEnd = utility.GetNumber("end");
                    listOfManipulatedUserStrings = utility.AddToEnd(listOfUserStrings, numberToAddToEnd.ToString());
                    break;
                case Manipulation.Add_Dollar_Sign_To_Beginning:
                    listOfManipulatedUserStrings = utility.AddToBeginning(listOfUserStrings, "$");
                    break;
                case Manipulation.Add_Exclamation_Point_To_End:
                    listOfManipulatedUserStrings = utility.AddToEnd(listOfUserStrings, "!");
                    break;
                default:
                    break;
            }
            Message.DisplayListOfManipulatedStrings(manipulation.ToString());
            foreach (var stringEntry in listOfUserStrings)
            {
                Console.WriteLine(stringEntry);
            }
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
