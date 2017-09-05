using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum Gender { Female, Male};
    public interface Animal
    {
        string Name { get; set; }

        int Age { get; set; }

        Gender gender { get; set; }

        string Classification();

        bool WarmBlooded();

        int NumberOfLegs();

        string NoiseMakes();

        bool LaysEggs();
    }
}
