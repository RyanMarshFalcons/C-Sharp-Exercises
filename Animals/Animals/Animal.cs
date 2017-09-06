using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum Gender { Female, Male};
    public enum Body_Temperature { Warm_Blooded, Cold_Blooded};

    public interface Animal
    {
        string Name { get; set; }

        int Age { get; set; }

        Gender Gender { get; set; }

        TypeOfAnimal TypeOfAnimal();

        string Classification();

        Body_Temperature BodyTemperature();

        int NumberOfLegs();

        string NoiseMakes();

        bool LaysEggs();
    }
}
