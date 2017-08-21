using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sine_Cosine_Tangent;
using Sine_Cosine_Tangent_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = utility.GetValidNumber();
            var trigFunction = utility.GetTrigFunction();
            switch (trigFunction)
            {
                case "A":
                    var SineOfNum = utility.GetSine(num);
                    Message.SineOfNum(num, SineOfNum);
                    break;
                case "B":
                    var cosineOfNum = utility.GetCosine(num);
                    Message.CosineOfNum(num, cosineOfNum);
                    break;
                case "C":
                    var tangentOfNum = utility.GetTangent(num);
                    Message.TangentOfNum(num, tangentOfNum);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
