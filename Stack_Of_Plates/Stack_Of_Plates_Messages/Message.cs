using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Of_Plates_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Stack Of Plates program where you will enter the colors of plates as you stack them and then I will tell you how many plates you will\nhave to remove to get a plate of a certain color. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectColorToAdd()
        {
            Console.WriteLine("\nWhat color of plate would you like to add to your stack:\nA) Blue\nB) Red\nC) Green\nD) Yellow\nE) Purple\nF) Pink\nG) Orange");
        }

        public static void NotAValidSelection(string input, string addToRemoveFrom)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. What color of plate would you\nlike to {addToRemoveFrom} your stack:\nA) Blue\nB) Red\nC) Green\nD) Yellow\nE) Purple\nF) Pink\nG) Orange");
        }

        public static void AddAnotherPlate()
        {
            Console.Write("\nWould you like to add another plate to your stack? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void SelectColorToRemove()
        {
            Console.WriteLine("\nWhat color of plate would you like to remove from your stack:\nA) Blue\nB) Red\nC) Green\nD) Yellow\nE) Purple\nF) Pink\nG) Orange");
        }

        public static void FoundPlate(int platesRemoved, string color)
        {
            Console.WriteLine($"\nYou will have to remove {platesRemoved} plates to retrieve a {color} plate. Press enter to\nclose the program.");
        }

        public static void DidntFindPlate(int platesRemoved, string color)
        {
            Console.WriteLine($"\nAfter removing all {platesRemoved} plates from the stack no {color} plate was found. Press\nenter to close the program.");
        }
    }
}
