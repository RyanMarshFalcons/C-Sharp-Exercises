using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals_Messages;
using System.Text.RegularExpressions;

namespace Animals
{
    public enum TypeOfAnimal { Cat, Cow, Crocodile, Dog, Goldfish, Goose, Parrot, Toadfish, Turtle};
    public class Utility
    {
        public string GetValidAnimalSelection()
        {
            Message.SelectAnimal();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.NotAValidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-I()]") && input.Length == 1;
        }
        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherAnimal();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public TypeOfAnimal ConvertLetterToAnimalType(string selection)
        {
            switch (selection)
            {
                case "A":
                    return TypeOfAnimal.Cat;
                    break;
                case "B":
                    return TypeOfAnimal.Cow;
                    break;
                case "C":
                    return TypeOfAnimal.Crocodile;
                    break;
                case "D":
                    return TypeOfAnimal.Dog;
                    break;
                case "E":
                    return TypeOfAnimal.Goldfish;
                    break;
                case "F":
                    return TypeOfAnimal.Goose;
                    break;
                case "G":
                    return TypeOfAnimal.Parrot;
                    break;
                case "H":
                    return TypeOfAnimal.Toadfish;
                    break;
                case "I":
                default:
                    return TypeOfAnimal.Turtle;
                    break;
            }
        }

        public Animal MakeNewAnimal(TypeOfAnimal animalType)
        {
            switch (animalType)
            {
                case TypeOfAnimal.Cat:
                    return new Cat();
                    break;
                case TypeOfAnimal.Cow:
                    return new Cow();
                    break;
                case TypeOfAnimal.Crocodile:
                    return new Crocodile();
                    break;
                case TypeOfAnimal.Dog:
                    return new Dog();
                    break;
                case TypeOfAnimal.Goldfish:
                    return new Goldfish();
                    break;
                case TypeOfAnimal.Goose:
                    return new Goose();
                    break;
                case TypeOfAnimal.Parrot:
                    return new Parrot();
                    break;
                case TypeOfAnimal.Toadfish:
                    return new Toadfish();
                    break;
                case TypeOfAnimal.Turtle:
                default:
                    return new Turtle();
                    break;
            }
        }

        public string GetAnimalName(string animalType)
        {
            var userInput = "";
            Message.AskName(animalType);
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough(animalType);
                }
                else
                {
                    validInput = true;
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return input.Length < 1;
        }

        public int GetAnimalAge(string name)
        {
            Message.AskAge(name);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, name);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(name);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public Gender GetAnimalGender(string name, string animalType)
        {
            Message.AskGender(name, animalType);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidGender(input) == false)
                {
                    Message.InvalidGender(input, name, animalType);
                }
                else
                {
                    isValidInput = true;
                }
            }
            if (input == "A")
            {
                return Gender.Female;
            }
            else
            {
                return Gender.Male;
            }
        }

        public bool CheckIfValidGender(string input)
        {
            return input == "A" || input == "B";
        }

        public void DisplayReslts(List<Animal> animals)
        {
            Message.DisplayResults();
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"Animal number {i+1}");
                Console.WriteLine($"Type of animal: {animals[i].TypeOfAnimal()}");
                Console.WriteLine($"Name: {animals[i].Name}");
                Console.WriteLine($"Age: {animals[i].Age} years old");
                Console.WriteLine($"Gender {animals[i].Gender}");
                Console.WriteLine($"Classification: {animals[i].Classification()}");
                Console.WriteLine($"Body temperature control: {animals[i].BodyTemperature()}");
                Console.WriteLine($"Number of legs: {animals[i].NumberOfLegs()}");
                Console.WriteLine($"Noise makes: {animals[i].NoiseMakes()}");
                Console.WriteLine($"Lays eggs: { animals[i].LaysEggs()}");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
