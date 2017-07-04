using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
using Messages;

namespace Startup
{
    public enum TypeOfShape { Square, Rectangle, Triangle, Trapezoid, Circle};
    class Program
    {
        static void Main(string[] args)
        {
            var shapeType = GetShapeType();
            DisplayShapeCharacteristics(shapeType);
            Console.ReadLine();
        }

        public static TypeOfShape GetShapeType()
        {
            var ShapeSelection = GetValidShapeSelection();
            var ShapeType = TypeOfShape.Square;
            switch (ShapeSelection)
            {
                case "A":
                case "a":
                    ShapeType = TypeOfShape.Square;
                    break;
                case "B":
                case "b":
                    ShapeType = TypeOfShape.Rectangle;
                    break;
                case "C":
                case "c":
                    ShapeType = TypeOfShape.Triangle;
                    break;
                case "D":
                case "d":
                    ShapeType = TypeOfShape.Trapezoid;
                    break;
                case "E":
                case "e":
                    ShapeType = TypeOfShape.Circle;
                    break;
            }
            return ShapeType;
        }

        public static string GetValidShapeSelection()
        {
            var validSelection = false;
            var shapeSelection = "";
            Message.SelectShapeType();
            do
            {
                shapeSelection = Console.ReadLine();
                if ((shapeSelection == "A") || (shapeSelection == "a") || (shapeSelection == "B") || (shapeSelection == "b") || (shapeSelection == "C") || (shapeSelection == "c") || (shapeSelection == "D") || (shapeSelection == "d") || (shapeSelection == "E") || (shapeSelection == "e"))
                {
                    validSelection = true;
                }
                else
                {
                    Message.InvalidShapeSelection(shapeSelection);
                }
            } while (validSelection == false);
            return shapeSelection;           
        }

        public static void DisplayShapeCharacteristics(TypeOfShape shapeType)
        {
            switch (shapeType)
            {
                case TypeOfShape.Square:
                    Message.DisplaySquareCharacteristics();
                    var square = BuildASquare();
                    Message.DisplayResult("square", square.CalculateArea(), square.CalculatePerimiter());
                    break;
                case TypeOfShape.Rectangle:
                    Message.DisplayRectangleCharacteristics();
                    var rectangle = BuildARectangle();
                    Message.DisplayResult("rectangle", rectangle.CalculateArea(), rectangle.CalculatePerimiter());
                    break;
                case TypeOfShape.Triangle:
                    Message.DisplayTriangleCharacteristics();
                    var triangle = BuildATriangle();
                    Message.DisplayResult("triangle", triangle.CalculateArea(), triangle.CalculatePerimiter());
                    break;
                case TypeOfShape.Trapezoid:
                    Message.DisplayTrapezoidCharacteristics();
                    var trapezoid = BuildATrapezoid();
                    Message.DisplayResult("trapezoid", trapezoid.CalculateArea(), trapezoid.CalculatePerimiter());
                    break;
                case TypeOfShape.Circle:
                    Message.DisplayCircleCharacteristics();
                    var circle = BuildACircle();
                    Message.DisplayResult("circle", circle.CalculateArea(), circle.CalculatePerimiter());
                    break;
                default:
                    break;
            }
        }

        public static bool IsADoubleGreaterThanZero(string input)
        {
            var inputAsDouble = 0.0;
            double.TryParse(input, out inputAsDouble);
            return inputAsDouble > 0;
        }
        public static Square BuildASquare()
        {
            var square = new Square();
            square.side = GetLegitimateInput("side", "square");
            return square;
        }
        public static Rectangle BuildARectangle()
        {
            var rectangle = new Rectangle();
            rectangle.height = GetLegitimateInput("height", "rectangle");
            rectangle.width = GetLegitimateInput("width", "rectangle");
            return rectangle;
        }

        public static Triangle BuildATriangle()
        {
            var triangle = new Triangle();
            triangle.baseSide = GetLegitimateInput("base side", "triangle");
            triangle.side2 = GetLegitimateInput("second side", "triangle");
            triangle.side3 = GetLegitimateInput("third side", "triangle");
            triangle.height = GetLegitimateInput("height", "triangle");          
            return triangle;
        }

        public static Trapezoid BuildATrapezoid()
        {
            var trapezoid = new Trapezoid();
            trapezoid.base1 = GetLegitimateInput("base one", "trapezoid");
            trapezoid.base2 = GetLegitimateInput("base two", "trapezoid");
            trapezoid.leg1 = GetLegitimateInput("leg one", "trapezoid");
            trapezoid.leg2 = GetLegitimateInput("leg two", "trapezoid");
            trapezoid.height = GetLegitimateInput("height", "trapezoid");
            return trapezoid;
        }

        public static Circle BuildACircle()
        {
            var circle = new Circle();
            circle.radius = GetLegitimateInput("radius", "circle");
            return circle;
        }

        public static double GetLegitimateInput (string sideType, string shapeType)
        {
            bool legitimateInput = false;
            var sideAsString = "";
            do
            {
                Console.Write($"What would you like the length of the {sideType} of your {shapeType} to be: ");
                sideAsString = Console.ReadLine();
                if (IsADoubleGreaterThanZero(sideAsString))
                {
                    legitimateInput = true;
                }
                else
                {
                    Message.PositiveDoubleWasNotInput(sideAsString);
                }

            } while (legitimateInput == false);
            return Convert.ToDouble(sideAsString);
        }
    }
}
