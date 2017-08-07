using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPop_Messages;

namespace FizzBuzzPop
{
    public class Utility
    {
        public string EvaluateNumber(int num)
        {
            if ((IsFizz(num)) && (IsBuzz(num)) && (IsPop(num)))
            {
                return "FizzBuzzPop";
            }
            else if ((IsFizz(num)) && (IsBuzz(num)))
            {
                return "FizzBuzz";
            }
            else if ((IsFizz(num)) && (IsPop(num)))
            {
                return "FizzPop";
            }
            else if ((IsBuzz(num)) && (IsPop(num)))
            {
                return "BuzzPop";
            }
            else if (IsFizz(num))
            {
                return "Fizz";
            }
            else if (IsBuzz(num))
            {
                return "Buzz";
            }
            else if (IsPop(num))
            {
                return "Pop";
            }
            else
            {
                return num.ToString();
            }
        }

        public bool IsFizz(int num)
        {
            return num % 3 == 0;
        }

        public bool IsBuzz(int num)
        {
            return num % 5 == 0;
        }

        public bool IsPop(int num)
        {
            return num % 7 == 0;
        }
    }
}
