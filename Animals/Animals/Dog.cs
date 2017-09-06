using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Dog;
        }

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
            return "Woof";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public Body_Temperature BodyTemperature()
        {
            return Body_Temperature.Warm_Blooded;
        }
    }
}
