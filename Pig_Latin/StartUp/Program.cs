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
            var userString = utility.GetUserString();
            var userStringAsPigLatin = utility.TranslateToPigLatin(userString);
            Message.DisplayInPigLatin(userStringAsPigLatin);
            Console.ReadLine();
        }
    }
}
