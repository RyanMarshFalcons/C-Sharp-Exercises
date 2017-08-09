using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade_Point_Average_Messages;

namespace Grade_Point_Average
{
    public class Utility
    {
        public List<string> CourseSchedule()
        {
            return new List<string>() { "English", "World History", "Algebra", "Physical Science", "French", "Health", "Art" };
        }

        public string GetValidEntry(string className)
        {
            Message.EnterGrade(className);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidGrade(input) == false)
                {
                    Message.NotAGrade(input, className);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidGrade(string input)
        {
            return ((input == "F") || (input == "D-") || (input == "D") || (input == "D+") || (input == "C-") || (input == "C") || (input == "C+") || (input == "B-") || (input == "B") || (input == "B+") || (input == "A-") || (input == "A"));
        }

        public double CalculateGPA(Dictionary<string, string> courseGrades)
        {
            var sum = 0.0;
            foreach (var course in courseGrades)
            {
                sum += ConvertToGPA(course.Value);
            }
            return Math.Round(sum / courseGrades.Count(), 1);
        }

   
        public double ConvertToGPA(string letterGrade)
        {
            switch (letterGrade)
            {
                case "A":
                    return 4.0;
                    break;
                case "A-":
                    return 3.7;
                    break;
                case "B+":
                    return 3.3;
                    break;
                case "B":
                    return 3.0;
                    break;
                case "B-":
                    return 2.7;
                    break;
                case "C+":
                    return 2.3;
                    break;
                case "C":
                    return 2.0;
                    break;
                case "C-":
                    return 1.7;
                    break;
                case "D+":
                    return 1.3;
                    break;
                case "D":
                    return 1.0;
                    break;
                case "D-":
                    return 0.7;
                    break;
                case "F":
                default:
                    return 0.0;
                    break;
            }
        }
    }
}
