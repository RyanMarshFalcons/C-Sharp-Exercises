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
            Console.WriteLine("Hello and welcome to my Animals program where you will enter information about animals and then I will display even more information about them to you in a manner of your choosing. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectAnimal()
        {
            Console.Write("\nSelect an animal:\nA) Cat\nB) Cow\nC) Crocodile\nD) Dog\nE) Goldfish\nF) Goose\nG) Parrot\nH) Toadfish\nI) Turtle");
        }

        public static void NotAWord(string input)
        {
            Console.Write($"\nSorry but {input} is not a word. Please input a word: ");
        }

        public static void AddAnotherAnimal()
        {
            Console.Write("\nWould you like to enter another animal? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }
    }
}
