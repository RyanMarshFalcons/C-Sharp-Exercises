using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Table_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Ryan's Fine Dining Restaurant. You and your date would like to get a table tonight but did not make a reservation. Lets find out if you're able to\nget a table or not. Press enter to continue.");
            Console.ReadLine();
        }

        public static void HowFashionable(string person)
        {
            Console.Write($"\nOn a scale of 1 to 10 how fashionable {person} dressed: ");
        }

        public static void MustBeBetweenOneandTen(int num, string person)
        {
            Console.Write($"\nSorry but the number {num} is not between one and ten. On a scale of 1 to 10\nhow fashionable {person} dressed: ");
        }

        public static void NotANumber(string input, string person)
        {
            Console.Write($"\nSorry but {input} is not a number. On a scale of 1 to 10 how fashionable\n{person} dressed: ");
        }

        public static void SelectDayOfWeek()
        {
            Console.WriteLine("\nIs today:\nA) Monday\nB) Tuesday\nC) Wednesday\nD) Thursday\nE) Friday\nF) Saturday\nG) Sunday");
        }

        public static void NotADayOfTheWeek(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid seclection please enter A, B, C, D, E, F, or G: ");
        }

        public static void GetTheTable()
        {
            Console.WriteLine("\nCongratulations you and your date are able to get a table!!! Press enter to\nclose the program.");
        }

        public static void DontGetTable()
        {
            Console.WriteLine("\nUnfortunately you and your date were not able to get a table. Press enter to\nclose the program.");
        }

    }
}
