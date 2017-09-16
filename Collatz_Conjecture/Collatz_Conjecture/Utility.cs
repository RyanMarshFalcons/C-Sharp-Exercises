using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collatz_Conjecture_Messages;

namespace Collatz_Conjecture
{
    public class Utility
    {
        public int GetStartingNumber()
        {
            Message.InputNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public int GetNumberOfSteps(int startingNumber)
        {
            var counter = 0;
            Message.StepsListed(startingNumber);           
            while (startingNumber != 1)
            {
                if (IsEven(startingNumber))
                {
                    startingNumber = DivideByTwo(startingNumber);
                }
                else
                {
                    startingNumber = MultiplyByThreeAddOne(startingNumber);
                }
                counter += 1;
                Console.WriteLine(startingNumber);
            }
            return counter;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        } 

        public int DivideByTwo(int num)
        {
            return num / 2;
        }

        public int MultiplyByThreeAddOne(int num)
        {
            return num * 3 + 1;
        }
       
    }
}
