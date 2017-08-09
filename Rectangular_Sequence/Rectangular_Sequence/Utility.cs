using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangular_Sequence_Messages;

namespace Rectangular_Sequence
{
    public class Utility
    {
        public int GetNextNumber(int num)
        {
            return num * (num + 1);
        }
    }
}
