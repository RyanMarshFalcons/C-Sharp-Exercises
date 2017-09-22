using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Famous_Sequences;
using Famous_Sequences_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var selection = utility.GetValidSequenceSelection();
            var sequence = utility.ConvertToSequence(selection);
            var listOfNums = utility.ConstructSequence(sequence);
            utility.DisplayList(listOfNums);
            Message.ThankYou(sequence.ToString());
            Console.ReadLine();
        }
    }
}
