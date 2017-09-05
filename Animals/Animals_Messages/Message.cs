using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Animals program where you will enter information about\nanimals and then I will display even more information about them to you in a\nmanner of your choosing. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectAnimal()
        {
            Console.WriteLine("Select an animal:\nA) Cat\nB) Cow\nC) Crocodile\nD) Dog\nE) Goldfish\nF) Goose\nG) Parrot\nH) Toadfish\nI) Turtle");
        }

        public static void NotAValidSelection(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid selection.\nSelect an animal:\nA) Cat\nB) Cow\nC) Crocodile\nD) Dog\nE) Goldfish\nF) Goose\nG) Parrot\nH) Toadfish\nI) Turtle");
        }

        public static void AddAnotherAnimal()
        {
            Console.Write("\nWould you like to enter another animal? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void AskName(string animalType)
        {
            Console.WriteLine($"\nPlease enter the name of your {animalType}: ");
        }

        public static void NotLongEnough(string animalType)
        {
            Console.Write("\nYou must input at least one character for an animal's name.\nPlease enter the name of your {animalType}: ");
        }

        public static void AskAge(string name)
        {
            Console.WriteLine($"\nPlease enter how many years old {name} is: ");
        }

        public static void NotANumber(string input, string name)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter\nhow many years old {name} is: ");
        }

        public static void CantBeNegative(string name)
        {
            Console.Write($"\nSorry but age cannot be negative. Please enter\nhow many years old {name} is: ");
        }

        public static void AskGender(string name, string animalType)
        {
            Console.WriteLine($"\nIs {name} a male or a female {animalType}:\nA) Female\nB) Male");
        }

        public static void InvalidGender(string input, string name, string animalType)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nIs {name} a male or a female {animalType}:\nA) Female\nB) Male");
        }
    }
}
