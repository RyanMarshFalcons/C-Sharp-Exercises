using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;
using Animals_Messages;


namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var selection = utility.GetValidAnimalSelection();

            Console.ReadLine();
        }
    }
}
