using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;
using Animals_Messages;


namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var AnimalSelection = "";
            var typeOfAnimal = new TypeOfAnimal();
            var enterAnotherAnimal = true;
            var listOfAnimals = new List<Animal>();
            do
            {
                AnimalSelection = utility.GetValidAnimalSelection();
                typeOfAnimal = utility.ConvertLetterToAnimalType(AnimalSelection);
                var animal = utility.MakeNewAnimal(typeOfAnimal);
                animal.Name = utility.GetAnimalName(typeOfAnimal.ToString());
                animal.Age = utility.GetAnimalAge(animal.Name);
                animal.gender = utility.GetAnimalGender(animal.Name, typeOfAnimal.ToString());

                enterAnotherAnimal = utility.AskToContinue();
            } while (true);
            Console.ReadLine();
        }
    }
}
