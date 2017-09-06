using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Turtle : Animal
    {
        public int Age { get; set; }
        
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Turtle;
        }

        public string Classification()
        {
            return "Reptile";
        }

        public bool LaysEggs()
        {
            return true;
        }

        public string NoiseMakes()
        {
            return "Hiss";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public Body_Temperature BodyTemperature()
        {
            return Body_Temperature.Cold_Blooded;
        }
    }
}
