using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class Builder
    {
        public int ArabicNumber = 0;

        public Builder(int userInputAsInt)
        {
            ArabicNumber = userInputAsInt;
        }

        public string BuildRomanNumeral()
        {
            string inputAsRoman = "";

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

        foreach (KeyValuePair<int, string> entry in arabicToRoman)
        {
            inputAsRoman += Conversion(entry.Key, entry.Value);
        }

            return inputAsRoman;
        }  

        public string Conversion (int num, string symbol)
        {
            string numAsRoman = "";
            while (ArabicNumber >= num)
            {
                numAsRoman += symbol;
                ArabicNumber -= num;
            }
            return numAsRoman;
        }
    }
}


