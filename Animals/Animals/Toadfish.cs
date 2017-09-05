using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Toadfish : Animal
    {
        public int Age { get; set; }

        public Gender gender { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Fish";
        }

        public bool LaysEggs()
        {
            return true;
        }

        public string NoiseMakes()
        {
            return "hum";
        }

        public int NumberOfLegs()
        {
            return 0;
        }

        public bool WarmBlooded()
        {
            return false;
        }
    }
}
