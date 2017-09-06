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

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Toadfish;
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
            return "Hum";
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
