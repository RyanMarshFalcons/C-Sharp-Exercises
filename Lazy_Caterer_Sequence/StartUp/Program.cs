using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lazy_Caterer_Sequence;
using Lazy_Caterer_Sequence_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = 0;
            var listOfNums = new List<int>();
            for (int i = 0; i < 296; i++)
            {
                num = utility.GetNextNumber(i);
                listOfNums.Add(num);
            }
            foreach (var number in listOfNums)
            {
                Console.WriteLine(String.Format("{0:n0}", number));
            }
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
