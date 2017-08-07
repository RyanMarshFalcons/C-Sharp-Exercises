using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradebook_Messages;

namespace Gradebook
{
    public class Utility
    {
        public double GetValidEntry()
        {
            Message.EnterGrade();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfDouble(input) == false)
                {
                    Message.NotAGrade(input);
                }
                else
                {
                    if (CheckIfWithinRange(input) == false)
                    {
                        Message.MustBeBetween0and100();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return Double.Parse(input);
        }

        public bool CheckIfDouble(string input)
        {
            var num = 0.0;
            return Double.TryParse(input, out num);
        }

        public bool CheckIfWithinRange(string input)
        {
            return ((Double.Parse(input) >= 0) && (Double.Parse(input) <= 100));
        }

        public bool AskToContinue()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherGrade();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfyOrn(string input)
        {
            if ((input == "y") || (input == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetFinalGrade(List<double> gradebook)
        {
            var sum = 0.00;
            foreach (var grade in gradebook)
            {
                sum += grade;
            }
            return Math.Round(sum / gradebook.Count, 1);
        }

        public string GetLetterGrade(double finalGrade)
        {
            if (finalGrade >= 97)
            {
                return "A+";
            }
            else if (finalGrade >= 93)
            {
                return "A";
            }
            else if (finalGrade >= 90)
            {
                return "A-";
            }
            else if (finalGrade >= 87)
            {
                return "B+";
            }
            else if (finalGrade >= 83)
            {
                return "B";
            }
            else if (finalGrade >= 80)
            {
                return "B-";
            }
            else if (finalGrade >= 77)
            {
                return "C+";
            }
            else if (finalGrade >= 73)
            {
                return "C";
            }
            else if (finalGrade >= 70)
            {
                return "C-";
            }
            else if (finalGrade >= 67)
            {
                return "D+";
            }
            else if (finalGrade >= 63)
            {
                return "D";
            }
            else if (finalGrade >= 60)
            {
                return "D-";
            }
            else
            {
                return "F";
            }
        }

    }
}
