using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Block;
using Max_Block_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var blockLength = utility.FindLongestBlock(userString);
            Message.DisplayResult(blockLength);
            Console.ReadLine();
        }
    }
}
