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
            var num = 0;
            var listOfNums = new List<int>();
            switch (sequence)
            {
                case Sequence.Fibonacci:
                    Message.FibonacciDescription();
                    listOfNums = new List<int>() { 0, 1 };
                    for (int i = 0; i < 40; i++)
                    {
                        num = utility.FibonacciNextNumber(listOfNums);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.LazyCaterer:
                    Message.LazyCatererDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = utility.LazyCatererNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.Rectangular:
                    Message.RectangularDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = utility.RectangularNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.Triangular:
                    Message.TriangularDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = utility.TriangularNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                default:
                    break;
            }
            utility.DisplayList(listOfNums);
            Message.ThankYou(sequence.ToString());
            Console.ReadLine();
        }
    }
}
