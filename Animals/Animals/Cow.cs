using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cow : Animal
    {
        public int Age { get; set; }

        public Gender gender { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Mammal";
        }

        public bool LaysEggs()
        {
            return false;
        }

        public string NoiseMakes()
        {
            return "moo";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public bool WarmBlooded()
        {
            return true;
        }
    }
}
