using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Goldfish : Animal 
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Goldfish;
        }

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
            return "Kiss";
        }

        public int NumberOfLegs()
        {
            return 0;
        }

        public Body_Temperature BodyTemperature()
        {
            return Body_Temperature.Cold_Blooded;
        }
    }
}
