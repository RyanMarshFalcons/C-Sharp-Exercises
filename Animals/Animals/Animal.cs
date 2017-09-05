using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface Animal
    {
        string Name { get; set; }

        string Age { get; set; }

        bool Female { get; set; }

        string Classification();

        bool WarmBlooded();

        int NumberOfLegs();

        string NoiseMakes();

        bool LaysEggs();

    }
}
