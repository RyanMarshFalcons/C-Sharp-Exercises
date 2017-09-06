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

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public TypeOfAnimal TypeOfAnimal()
        {
            return Animals.TypeOfAnimal.Parrot;
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
            return "Chatter";
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
