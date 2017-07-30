using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangent;
using Tangent_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var tangentOfInput = utility.GetTangent(input);
            Message.TangentOfNum(input, tangentOfInput);
            Console.ReadLine();
        }
    }
}
