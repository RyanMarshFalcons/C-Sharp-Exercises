using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Exact_Change
{
    public class Verification
    {
        public bool Empty(string userEntry)
        {
            return userEntry == "";
        }

        public bool NotADecimal(string userEntry)
        {
            decimal result;
            return !Decimal.TryParse(userEntry, out result);
        }
        public bool NotAnInt(string userEntry)
        {
            int result;
            return !Int32.TryParse(userEntry, out result);
        }

        public bool Zero(decimal userEntryAsDecimal)
        {
            return userEntryAsDecimal == 0;
        }

        public bool Negative(decimal userEntryAsDecimal)
        {
            return userEntryAsDecimal < 0;
        }

        public bool TooManyTrailingDigits(decimal inputAsDecimal)
        {
            return ((SqlDecimal)(decimal)inputAsDecimal).Scale > 2;
        }
    }
}
