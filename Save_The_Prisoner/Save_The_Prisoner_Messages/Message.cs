using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_The_Prisoner_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Save The Prisoner program where a jailer is passing out sweets to a group of prisoners gathered in a circle seated by their Prisoner ID Number\nranging from 1 to the total number of prisoners in the circle. The last sweet\nthat the jailer is going to pass out is poisoned and you need to warn the\nprisoner who is going to be given the poisoned sweet based upon the Prisoner ID Number of the prisoner who is receiving the first sweet and how many total\nsweets are going to be passed out. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumberOfPrisoners()
        {
            Console.Write("Enter the number of prisoners in the circle: ");
        }

        public static void NumberOfPrisonersNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter the number of\nprisoners in the circle: ");
        }

        public static void LessThanTwoPrisoners()
        {
            Console.Write("\nSorry but there must be at least two prisoners in the circle. Enter the number\nof prisoners in the circle: ");
        }

        public static void EnterIDOfFirstPrisoner()
        {
            Console.Write("\nEnter the Prisoner ID Number of the prisoner who is going to be receiving the\nfirst sweet: ");
        }

        public static void PrisonerIDIsNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter the Prisoner ID\nNumber of the prisoner who is going to be receiving the first sweet: ");
        }

        public static void IDOfFirstPrisonerIsLessThanOne()
        {
            Console.Write("\nSorry but the Prisoner ID Number must be at least one. Enter the Prisoner ID\nNumber of the prisoner who is going to be receiving the first sweet: ");
        }

        public static void IDOfFirstPrisonerExceedsNumberOfPrisoners()
        {
            Console.Write("\nSorry but the Prisoner ID Number cannot be greater than the total number of\nprisoners in the circle. Enter the Prisoner ID Number of the prisoner who is\ngoing to be receiving the first sweet: ");
        }

        public static void EnterNumberOfSweets()
        {
            Console.Write("\nEnter the number of sweets that the jailer is going to pass out: ");
        }

        public static void NumberOfSweetssNotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Enter the number of sweets\nthat the jailer is going to pass out: ");
        }

        public static void LessThanOneSweet()
        {
            Console.Write("\nSorry but the jailer must pass out at least one sweet to the prisoners. Enter\nthe number of sweets that the jailer is going to pass out: ");
        }

        public static void DisplayResult(int IDOfPrisonerToWarn)
        {
            Console.WriteLine($"\nYou need to warn the prisoner with the Prisoner ID Number of {IDOfPrisonerToWarn} that he is\ngoing to be given the poisoned sweet. Press enter to close the program.");
        }
    }
}
