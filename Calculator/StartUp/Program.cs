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
            var operatorType = utility.GetValidOperator();
            var num2 = utility.GetValidNumber();
            switch (operatorType)
            {
                case "+":
                    var sum = utility.GetSum(num1, num2);
                    Message.DisplaySum(num1, num2, sum);
                    break;
                case "-":
                    var difference = utility.GetDifference(num1, num2);
                    Message.DisplayDifference(num1, num2, difference);
                    break;
                case "*":
                    var product = utility.GetProduct(num1, num2);
                    Message.DisplayProduct(num1, num2, product);
                    break;
                case "/":
                    var quotient = utility.GetQuotient(num1, num2);
                    Message.DisplayQuotient(num1, num2, quotient);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
