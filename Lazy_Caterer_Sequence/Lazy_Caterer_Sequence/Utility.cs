using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lazy_Caterer_Sequence_Messages;

namespace Lazy_Caterer_Sequence
{
    public class Utility
    {
        public int GetNextNumber(int num)
        {
            return (num * num + num + 2) / 2;
        }
    }
}
