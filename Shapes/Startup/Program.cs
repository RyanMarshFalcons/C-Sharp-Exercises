using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
using Messages;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var shapeSelectionLetter = utility.GetShapeSelectionLetter();
            var shapeSelection = utility.ConvertLetterToTypeOfShape(shapeSelectionLetter);
            utility.DisplayShapeCharacteristics(shapeSelection);
            Console.ReadLine();
        }
    }
}
