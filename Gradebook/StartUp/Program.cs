using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradebook;
using Gradebook_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var gradebook = new List<double>();
            var grade = 0.0;
            var addMoreGrades = true;
            do
            {
                grade = utility.GetValidEntry(gradebook.Count + 1);
                gradebook.Add(grade);
                addMoreGrades = utility.AskToContinue();
            } while (addMoreGrades == true);
            var finalGrade = utility.GetFinalGrade(gradebook);
            var letterGrade = utility.GetLetterGrade(finalGrade);
            Message.DisplayGrade(finalGrade, letterGrade);
            Console.ReadLine();
        }
    }
}
