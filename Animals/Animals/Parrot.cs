using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Parrot : Animal
    {
        public int Age { get; set; }

        public Gender gender { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Bird";
        }

        public bool LaysEggs()
        {
            return true;
        }

        public string NoiseMakes()
        {
            return "chatter";
        }

        public int NumberOfLegs()
        {
            return 2;
        }

        public bool WarmBlooded()
        {
            return true;
        }
    }
}
