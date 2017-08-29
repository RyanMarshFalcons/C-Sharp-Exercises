using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber();
            var operatorSelection = utility.GetValidOperatorSelection();
            var num2 = 0.0;
            if ((operatorSelection == "A") || (operatorSelection == "B") || (operatorSelection == "C") || (operatorSelection == "D"))
            {
                num2 = utility.GetValidNumber();
            }
            switch (operatorSelection)
            {
                case "A":
                    var sum = utility.GetSum(num1, num2);
                    Message.DisplaySum(num1, num2, sum);
                    break;
                case "B":
                    var difference = utility.GetDifference(num1, num2);
                    Message.DisplayDifference(num1, num2, difference);
                    break;
                case "C":
                    var product = utility.GetProduct(num1, num2);
                    Message.DisplayProduct(num1, num2, product);
                    break;
                case "D":
                    var quotient = utility.GetQuotient(num1, num2);
                    Message.DisplayQuotient(num1, num2, quotient);
                    break;
                case "E":
                    var squared = utility.GetNumberSquared(num1);
                    Message.DisplayNumberSquared(num1, squared);
                    break;
                case "F":
                    var cubed = utility.GetNumberCubed(num1);
                    Message.DisplayNumberCubed(num1, cubed);
                    break;
                case "G":
                    var tesseracted = utility.GetNumberTesseracted(num1);
                    Message.DisplayNumberTesseracted(num1, tesseracted);
                    break;
                case "H":
                    var squareRoot = utility.GetSquareRoot(num1);
                    Message.DisplaySquareRootOfNum(num1, squareRoot);
                    break;
                case "I":
                    var sine = utility.GetSine(num1);
                    Message.DisplaySineOfNum(num1, sine);
                    break;
                case "J":
                    var cosine = utility.GetCosine(num1);
                    Message.DisplayCosineOfNum(num1, cosine);
                    break;
                case "K":
                    var tangent = utility.GetTangent(num1);
                    Message.DisplayTangentOfNum(num1, tangent);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
