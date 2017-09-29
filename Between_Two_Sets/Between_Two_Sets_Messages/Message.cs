using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Between Two Sets program where you will enter two sets of three\nnumbers and I will tell you what numbers if any have all of the numbers in the\nfirst set as factors of them and are also factors of all of the elements in the second set. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(int numberPlace, string firstSecond)
        {
            Console.Write($"\nPlease enter entry {numberPlace} of the {firstSecond} set: ");
        }

        public static void NotANumber(string input, int numberPlace, string firstSecond)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter entry {numberPlace} of the\n{firstSecond} set: ");
        }

        public static void MustBePositive(int numberPlace, string firstSecond)
        {
            Console.Write($"\nSorry but the number must be positive. Please enter entry {numberPlace} of the {firstSecond}\nset: ");
        }

        public static void DisplayNumbersBetween(List<int> numsBetween, int count)
        {
            Console.WriteLine($"\nCongratulations there were {count} numbers between your first and second sets!!!\nThey are displayed below:");
            foreach (var item in numsBetween)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPress enter to close the program.");
        }

        public static void NoNumbersBetween()
        {
            Console.WriteLine("\nUnfortunately there are no numbers that both have all three numbers in your\nfirst set as factors and are factors of all three numbers in your second set.\nPress enter to close the program.");
        }
    }
}
