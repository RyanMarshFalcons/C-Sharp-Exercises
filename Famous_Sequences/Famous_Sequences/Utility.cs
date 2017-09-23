using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Famous_Sequences_Messages;
using System.Text.RegularExpressions;

namespace Famous_Sequences
{
    public enum Sequence { Fibonacci, LazyCaterer, Rectangular, Triangular };
    public class Utility
    {
        public string GetValidSequenceSelection()
        {
            Message.SelectSequence();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-D]") && input.Length == 1;
        }

        public Sequence ConvertToSequence(string selection)
        {
            switch (selection)
            {
                case "A":
                    return Sequence.Fibonacci;
                    break;
                case "B":
                    return Sequence.LazyCaterer;
                    break;
                case "C":
                    return Sequence.Rectangular;
                    break;
                case "D":
                default:
                    return Sequence.Triangular;
                    break;
            }
        }

        public List<int> ConstructSequence(Sequence sequence)
        {
            var num = 0;
            var listOfNums = new List<int>();
            switch (sequence)
            {
                case Sequence.Fibonacci:
                    Message.FibonacciDescription();
                    listOfNums = new List<int>() { 0, 1 };
                    for (int i = 0; i < 40; i++)
                    {
                        num = FibonacciNextNumber(listOfNums);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.LazyCaterer:
                    Message.LazyCatererDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = LazyCatererNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.Rectangular:
                    Message.RectangularDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = RectangularNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                case Sequence.Triangular:
                    Message.TriangularDescription();
                    for (int i = 0; i < 40; i++)
                    {
                        num = TriangularNextNumber(i);
                        listOfNums.Add(num);
                    }
                    break;
                default:
                    break;
            }
            return listOfNums;
        }
        
        public int FibonacciNextNumber(List<int> listOfNums)
        {
            return listOfNums[listOfNums.Count - 1] + listOfNums[listOfNums.Count - 2];
        }

        public int LazyCatererNextNumber(int num)
        {
            return (num * num + num + 2) / 2;
        }

        public int RectangularNextNumber(int num)
        {
            return num * (num + 1);
        }

        public int TriangularNextNumber(int num)
        {
            return (num * (num + 1)) / 2;
        }

        public void DisplayList(List<int> listOfNums)
        {
            foreach (var number in listOfNums)
            {
                Console.WriteLine(String.Format("{0:n0}", number));
            }
        }
    }
}
