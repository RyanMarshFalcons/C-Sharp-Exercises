using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosine;
using Cosine_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var cosineOfInput = utility.GetCosine(input);
            Message.CosineOfNum(input, cosineOfInput);
            Console.ReadLine();
        }
    }
}
