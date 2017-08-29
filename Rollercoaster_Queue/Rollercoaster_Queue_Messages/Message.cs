using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollercoaster_Queue_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Rollercoaster Queue program where you will enter the\nnames and weights of ten people waiting in line to ride a rollercaster and then I will tell you what car they will sit in. Each rollercoaster car can hold up to 500 pounds. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestName(int personNumber)
        {
            Console.Write($"\nEnter the name of person number {personNumber}: ");
        }

        public static void RequestWeight(string name)
        {
            Console.Write($"\nEnter how many pounds {name} weighs: ");
        }

        public static void NotAValidName(int personNumber)
        {
            Console.Write($"\nYou must enter at least one character for a person's name. Enter the name of\nperson number {personNumber}: ");
        }

        public static void NotANumber(string input, string name)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter how many pounds {name} weighs: ");
        }

        public static void NotAvalidWeight(string name)
        {
            Console.Write($"\nA person's weight must be a number that is greater than zero. Enter how many\npounds {name} weighs: ");
        }

        public static void TooHeavy(string name)
        {
            Console.WriteLine($"\nThe maximum weight per rollercoaster car is 500 pounds so {name}\nis not allowed onto the rollercoaster.");
        }

        public static void GoesOnCar(string name, int carNumber)
        {
            Console.WriteLine($"\n{name} gets on car number {carNumber}.");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("\nI hope that you enjoyed my Rollercoaster Queue program. Press enter to close theprogram.");
        }
    }
}
