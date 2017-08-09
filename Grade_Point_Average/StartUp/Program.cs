using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade_Point_Average;
using Grade_Point_Average_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var courseSchedule = utility.CourseSchedule();
            var courseGrades = new Dictionary<string, string>();
            foreach (var course in courseSchedule)
            {
                courseGrades.Add(course, utility.GetValidEntry(course));
            }
            var GPA = utility.CalculateGPA(courseGrades);
            Message.DisplayGradePointAverage(GPA);
            Console.ReadLine();
        }
    }
}
