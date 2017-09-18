using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman_Numerals_Messages;

namespace Roman_Numerals
{
    public class Utility
    {
        public int GetValidArabicNumber()
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
                    else if (CheckIfTooHigh(input))
                    {
                        Message.IsTooHigh();
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

        public bool CheckIfTooHigh(string input)
        {
            return int.Parse(input) > 3999;
        }

        public string BuildRomanNumeral(int ArabicNumber)
        {
            var arabicToRoman = new Dictionary<int, string>()
                        {
                            { 1000, "M" },
                            { 900, "CM" },
                            { 500, "D" },
                            { 400, "CD" },
                            { 100, "C" },
                            { 90, "XC" },
                            { 50, "L" },
                            { 40, "XL" },
                            { 10, "X" },
                            { 9, "IX" },
                            { 5, "V" },
                            { 4, "IV" },
                            { 1, "I" }
                        };
            var numAsRoman = "";
            foreach (var entry in arabicToRoman)
            {
                while (ArabicNumber >= entry.Key)
                {
                    numAsRoman += entry.Value;
                    ArabicNumber -= entry.Key;
                }
            }
            return numAsRoman;
        }  
    }
}


