using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack_Of_Plates;
using Stack_Of_Plates_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var plateStack = new Stack<string>();
            var colorToAdd = "";
            var continueAsking = true;
            while (continueAsking == true)
            {
                Message.SelectColorToAdd();
                colorToAdd = utility.GetPlateColor("add to");
                plateStack.Push(colorToAdd);
                continueAsking = utility.AskToContinue();
            }
            Message.SelectColorToRemove();
            var colorToRemove = utility.GetPlateColor("remove from");
            var stackCount = plateStack.Count;
            var retrievalCount = utility.RetrievePlate(plateStack, colorToRemove);
            var foundPlate = utility.CheckIfFound(retrievalCount);
            if (foundPlate == false)
            {
                retrievalCount = stackCount;
            }
            colorToRemove = utility.ConvertLetterToColor(colorToRemove);
            utility.DisplayResults(foundPlate, retrievalCount, colorToRemove);
            Console.ReadLine();
        }
    }
}
