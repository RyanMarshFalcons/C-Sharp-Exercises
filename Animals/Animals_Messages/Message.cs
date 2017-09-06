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
            Console.WriteLine("Hello and welcome to my Animals program where you will enter information about\nanimals and then I will display even more information about them to you. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void SelectAnimal()
        {
            Console.WriteLine("Select an animal:\nA) Cat\nB) Cow\nC) Crocodile\nD) Dog\nE) Goldfish\nF) Goose\nG) Parrot\nH) Toadfish\nI) Turtle");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nSelect an animal:\nA) Cat\nB) Cow\nC) Crocodile\nD) Dog\nE) Goldfish\nF) Goose\nG) Parrot\nH) Toadfish\nI) Turtle");
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
            Console.Write($"\nPlease enter the name of your {animalType}: ");
        }

        public static void NotLongEnough(string animalType)
        {
            Console.Write($"\nYou must input at least one character for an animal's name. Please enter the\nname of your {animalType}: ");
        }

        public static void AskAge(string name)
        {
            Console.Write($"\nPlease enter how many years old {name} is: ");
        }

        public static void NotANumber(string input, string name)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many years old\n{name} is: ");
        }

        public static void CantBeNegative(string name)
        {
            Console.Write($"\nSorry but age cannot be negative. Please enter how many years old\n{name} is: ");
        }

        public static void AskGender(string name, string animalType)
        {
            Console.WriteLine($"\nIs {name} a male or a female {animalType}:\nA) Female\nB) Male");
        }

        public static void InvalidGender(string input, string name, string animalType)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nIs {name} a male or a female {animalType}:\nA) Female\nB) Male");
        }

        public static void DisplayResults()
        {
            Console.WriteLine($"\nYour animals and all of their information will be displayed below. Press enter\nto continue.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine($"Thank you for using my Animals program. I hope that you enjoyed using it. Press enter to close the program.");
        }
    }
}
