using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Frame
    {
        public int FirstRoll { get; set; }

        public int SecondRoll { get; set; }

        public bool WasStrike()
        {
            return FirstRoll == 10;
        }

        public bool WasSpare()
        {
            return FirstRoll + SecondRoll == 10 && FirstRoll != 10;
        }
    }
}
