using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array_Manipulation_Messages;
using System.Text.RegularExpressions;

namespace Array_Manipulation
{
    public enum Manipulation { Sort_Lowest_To_Highest, Sort_Highest_To_Lowest, Add_2_To_All, Add_3_To_Odd, Add_4_To_Even, Multiply_All_By_5, Replace_Highest_With_Lowest, Replace_Lowest_With_Highest, Shift_Left, Shift_Right, Minus_10_Triple, Minus_20_Quadruple };
    public class Utility
    {
        public int GetValidNumber(string firstSecondModulus)
        {
            Message.InputNumber(firstSecondModulus);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecondModulus);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public string ArrayAsString(int[] nums)
        {
            var arrayAsStringBuilder = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                arrayAsStringBuilder.Append("[" + nums[i] + "] ");
            }
            return arrayAsStringBuilder.ToString();
        }

        public string GetSelection()
        {
            Message.RequestManipulation();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.InvalidSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-L]") && input.Length == 1;
        }

        public Manipulation ConvertLetterToManipulation(string letterSelected)
        {
            switch (letterSelected)
            {
                case "A":
                    return Manipulation.Sort_Lowest_To_Highest;
                    break;
                case "B":
                    return Manipulation.Sort_Highest_To_Lowest;
                    break;
                case "C":
                    return Manipulation.Add_2_To_All;
                    break;
                case "D":
                    return Manipulation.Add_3_To_Odd;
                    break;
                case "E":
                    return Manipulation.Add_4_To_Even;
                    break;
                case "F":
                    return Manipulation.Multiply_All_By_5;
                    break;
                case "G":
                    return Manipulation.Replace_Highest_With_Lowest;
                    break;
                case "H":
                    return Manipulation.Replace_Lowest_With_Highest;
                    break;
                case "I":
                    return Manipulation.Shift_Left;
                    break;
                case "J":
                    return Manipulation.Shift_Right;
                    break;
                case "K":
                    return Manipulation.Minus_10_Triple;
                    break;
                case "L":
                default:
                    return Manipulation.Minus_20_Quadruple;
                    break;
            }
        }

        public int[] SortLowestToHighest(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }

        public int[] SortHighestToLowest(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums;
        }

        public int[] AddTwoToAll(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + 2;
            }
            return nums;
        }

        public int[] AddThreeToOdd(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums[i] = nums[i] + 3;
                }
            }
            return nums;
        }

        public int[] AddFourToEvens(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] = nums[i] + 4;
                }
            }
            return nums;
        }

        public int[] MultiplyAllByFive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * 5;
            }
            return nums;
        }

        public int GetHighest(int[] nums)
        {
            var highest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
        }

        public int GetLowest(int[] nums)
        {
            var lowest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < lowest)
                {
                    lowest = nums[i];
                }
            }
            return lowest;
        }

        public int[] ReplaceHighestWithLowest(int[] nums, int highest, int lowest)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == highest)
                {
                    nums[i] = lowest;
                }
            }
            return nums;
        }

        public int[] ReplaceLowestWithHighest(int[] nums, int highest, int lowest)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == lowest)
                {
                    nums[i] = highest;
                }
            }
            return nums;
        }

        public int[] ShiftLeft(int[] nums)
        {
            var temp = nums[0];
            for (int i = 0; i < nums.Length -1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            return nums;
        }

        public int[] ShiftRight(int[] nums)
        {
            var temp = nums[nums.Length -1];
            for (int i = nums.Length -1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = temp;
            return nums;
        }

        public int[] MinusTenTriple(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (nums[i] - 10) * 3;
            }
            return nums;
        }

        public int[] MinusTwentyQuadruple(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (nums[i] - 20) * 4;
            }
            return nums;
        }
    }
}
