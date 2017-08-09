using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cube_Sequence_Messages;

namespace Cube_Sequence
{
    public class Utility
    {
        public int GetNextNumber(int num)
        {
            return num * num * num;
        }
    }
}
