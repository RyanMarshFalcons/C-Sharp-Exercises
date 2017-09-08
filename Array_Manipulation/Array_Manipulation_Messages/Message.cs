using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulation_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Array Manipulation program where you will enter seven\nnumbers that will form an integer array and then you will select how you want meto manipulate your numbers in the ineger array for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string whichNumber)
        {
            Console.Write($"\nEnter the {whichNumber} number: ");
        }

        public static void NotANumber(string input, string whichNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {whichNumber} number: ");
        }

        public static void DisplayOriginalArray(string arrayAsString)
        {
            Console.WriteLine($"\nHere is your array before any manipulation:\n{arrayAsString}\nPress enter to continue");
            Console.ReadLine();
        }

        public static void RequestManipulation()
        {
            Console.WriteLine("Please select which manipulation you wish for me to perform on your array:\nA) Sort your numbers from lowest to highest\nB) Sort your numbers from highest to lowest\nC) Add 2 to every number in your array\nD) Add 3 to all the odd numbers in your array\nE) Add 4 to all the even numbers in your array\nF) Multiply all the numbers in your array by 5\nG) Replace the highest number in your array with the lowest number\nH) Replace the lowest number in your array with the highest number\nI) Shift all the elements in your array to the left\nJ) Shift all the elements in your array to the right\nK) Subtract 10 and then triple every number\nL) Subtract 20 and quadruple every number");
        }

        public static void InvalidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nPlease select which manipulation you wish for me to perform on your array:\nA) Sort your numbers from lowest to highest\nB) Sort your numbers from highest to lowest\nC) Add 2 to every number in your array\nD) Add 3 to all the odd numbers in your array\nE) Add 4 to all the even numbers in your array\nF) Multiply all the numbers in your array by 5\nG) Replace the highest number in your array with the lowest number\nH) Replace the lowest number in your array with the highest number\nI) Shift all the elements in your array to the left\nJ) Shift all the elements in your array to the right\nK) Subtract 10 and then triple every number\nL) Subtract 20 and quadruple every number");
        }

        public static void DisplayManipulatedArray(string arrayAsString, string manipulationType)
        {
            Console.WriteLine($"\nHere is your array after {manipulationType} manipulation:\n{arrayAsString}\nPress enter to close the program.");
        }
    }
}
