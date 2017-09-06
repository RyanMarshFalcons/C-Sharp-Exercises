using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Goose : Animal
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Goose;
        }

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
            return "Honk";
        }

        public int NumberOfLegs()
        {
            return 2;
        }

        public Body_Temperature BodyTemperature()
        {
            return Body_Temperature.Warm_Blooded;
        }
    }
}
