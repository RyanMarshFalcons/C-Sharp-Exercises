using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    public class Verification
    {
        public bool Empty(string userEntry)
        {
            return userEntry == "";
        }

        public bool NotANumber(string userEntry)
        {
            int result;
            return !Int32.TryParse(userEntry, out result);
        }

        public bool Zero(int userEntryAsInt)
        {
            return userEntryAsInt == 0;
        }

        public bool Negative(int userEntryAsInt)
        {
            return userEntryAsInt < 0;
        }

        public bool TooHigh(int userEntryAsInt)
        {
            return userEntryAsInt > 3999;
        }
    }
}
