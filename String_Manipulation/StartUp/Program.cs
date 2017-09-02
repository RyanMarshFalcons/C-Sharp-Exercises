using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Manipulation;
using String_Manipulation_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetUserString();
            var selection = utility.GetSelection();
            var manipulation = utility.ConvertLetterToManipulation(selection);
            var newString = "";
            switch (manipulation)
            {
                case Manipulation.Front_Back:
                    newString = utility.FrontBack(userString);
                    break;
                case Manipulation.Front_Around:
                    newString = utility.FrontAround(userString);
                    break;
                case Manipulation.Back_Around:
                    newString = utility.BackAround(userString);
                    break;
                case Manipulation.Middle_Around:
                    newString = utility.MiddleAround(userString);
                    break;
                case Manipulation.First_3_Times_3:
                    newString = utility.FirstThree3Times(userString);
                    break;
                case Manipulation.Last_3_Times_3:
                    newString = utility.LastThree3Times(userString);
                    break;
                case Manipulation.First_3_Uppercase:
                    newString = utility.FirstThreeUppercase(userString);
                    break;
                case Manipulation.Last_3_Uppercase:
                    newString = utility.LastThreeUppercase(userString);
                    break;
                case Manipulation.Double_Characters:
                    newString = utility.DoubleCharacters(userString);
                    break;
                case Manipulation.Triple_Characters:
                    newString = utility.TripleCharacters(userString);
                    break;
                case Manipulation.Reverse_String:
                    newString = utility.ReverseString(userString);
                    break;
                case Manipulation.Explode_String:
                    newString = utility.StringExplosion(userString);
                    break;
                case Manipulation.Swap_Cases:
                    newString = utility.SwapCases(userString);
                    break;
                case Manipulation.Shift_Third:
                    newString = utility.ShiftThird(userString);
                    break;
            }
            Message.DisplayResult(newString, manipulation.ToString());
            Console.ReadLine();
        }
    }
}
