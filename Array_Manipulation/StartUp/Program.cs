using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array_Manipulation;
using Array_Manipulation_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[7];
            nums[0] = utility.GetValidNumber("first");
            nums[1] = utility.GetValidNumber("second");
            nums[2] = utility.GetValidNumber("third");
            nums[3] = utility.GetValidNumber("fourth");
            nums[4] = utility.GetValidNumber("fifth");
            nums[5] = utility.GetValidNumber("sixth");
            nums[6] = utility.GetValidNumber("seventh");
            var arrayAsString = utility.ArrayAsString(nums);
            Message.DisplayOriginalArray(arrayAsString);
            var selectionLetter = utility.GetSelection();
            var manipulation = utility.ConvertLetterToManipulation(selectionLetter);
            var manipulatedNums = new int[7];
            var highest = utility.GetHighest(nums);
            var lowest = utility.GetLowest(nums);
            switch (manipulation)
            {
                case Manipulation.Sort_Lowest_To_Highest:
                    manipulatedNums = utility.SortLowestToHighest(nums);
                    break;
                case Manipulation.Sort_Highest_To_Lowest:
                    manipulatedNums = utility.SortHighestToLowest(nums);
                    break;
                case Manipulation.Add_2_To_All:
                    manipulatedNums = utility.AddTwoToAll(nums);
                    break;
                case Manipulation.Add_3_To_Odd:
                    manipulatedNums = utility.AddThreeToOdd(nums);
                    break;
                case Manipulation.Add_4_To_Even:
                    manipulatedNums = utility.AddFourToEvens(nums);
                    break;
                case Manipulation.Multiply_All_By_5:
                    manipulatedNums = utility.MultiplyAllByFive(nums);
                    break;
                case Manipulation.Replace_Highest_With_Lowest:
                    manipulatedNums = utility.ReplaceHighestWithLowest(nums, highest, lowest);
                    break;
                case Manipulation.Replace_Lowest_With_Highest:
                    manipulatedNums = utility.ReplaceLowestWithHighest(nums, highest, lowest);
                    break;
                case Manipulation.Shift_Left:
                    manipulatedNums = utility.ShiftLeft(nums);
                    break;
                case Manipulation.Shift_Right:
                    manipulatedNums = utility.ShiftRight(nums);
                    break;
                case Manipulation.Minus_10_Triple:
                    manipulatedNums = utility.MinusTenTriple(nums);
                    break;
                case Manipulation.Minus_20_Quadruple:
                    manipulatedNums = utility.MinusTwentyQuadruple(nums);
                    break;
                default:
                    break;
            }
            var manipulatedArrayAsString = utility.ArrayAsString(manipulatedNums);
            Message.DisplayManipulatedArray(manipulatedArrayAsString, manipulation.ToString());
            Console.ReadLine();
        }
    }
}
