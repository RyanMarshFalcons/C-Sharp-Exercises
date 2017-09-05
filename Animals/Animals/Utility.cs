using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals_Messages;

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
            return input == "A" || input == "B" || input == "C" || input == "D" || input == "E" || input == "F" || input == "G" || input == "H" || input == "I";
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
                    Message.NotAValidSelection(input);
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
    }
}
