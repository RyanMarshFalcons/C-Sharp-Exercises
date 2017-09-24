using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using System.Text.RegularExpressions;

namespace Shapes
{
    public enum TypeOfShape { Square, Rectangle, Triangle, Trapezoid, Circle };
    public class Utility
    {
        public string GetShapeSelectionLetter()
        {
            var validSelection = false;
            var input = "";
            Message.SelectShapeType();
            do
            {
                input = Console.ReadLine();
                if (!CheckIfValidSelection(input))
                {
                    Message.InvalidShapeSelection(input);
                }
                else
                {
                    validSelection = true;
                }
            } while (validSelection == false);
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return Regex.IsMatch(input, "[A-E]") && input.Length == 1;
        }

        public TypeOfShape ConvertLetterToTypeOfShape(string ShapeSelectionLetter)
        {
            switch (ShapeSelectionLetter)
            {
                case "A":
                    return TypeOfShape.Square;
                    break;
                case "B":
                    return TypeOfShape.Rectangle;
                    break;
                case "C":
                    return TypeOfShape.Triangle;
                    break;
                case "D":
                    return TypeOfShape.Trapezoid;
                    break;
                case "E":
                default:
                    return TypeOfShape.Circle;
                    break;
            }
        }

        public void DisplayShapeCharacteristics(TypeOfShape shapeType)
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

        public double GetSideLength(string sideType, string shapeType)
        {
            bool legitimateInput = false;
            var sideAsString = "";
            do
            {
                Message.AskSideLength(sideType, shapeType);
                sideAsString = Console.ReadLine();
                if (IsPositive(sideAsString))
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

        public bool IsPositive(string input)
        {
            var inputAsDouble = 0.0;
            double.TryParse(input, out inputAsDouble);
            return inputAsDouble > 0;
        }

        public Square BuildASquare()
        {
            var square = new Square();
            square.side = GetSideLength("side", "square");
            return square;
        }

        public Rectangle BuildARectangle()
        {
            var rectangle = new Rectangle();
            rectangle.height = GetSideLength("height", "rectangle");
            rectangle.width = GetSideLength("width", "rectangle");
            return rectangle;
        }

        public Triangle BuildATriangle()
        {
            var triangle = new Triangle();
            triangle.baseSide = GetSideLength("base side", "triangle");
            triangle.side2 = GetSideLength("second side", "triangle");
            triangle.side3 = GetSideLength("third side", "triangle");
            triangle.height = GetSideLength("height", "triangle");
            return triangle;
        }

        public Trapezoid BuildATrapezoid()
        {
            var trapezoid = new Trapezoid();
            trapezoid.base1 = GetSideLength("base one", "trapezoid");
            trapezoid.base2 = GetSideLength("base two", "trapezoid");
            trapezoid.leg1 = GetSideLength("leg one", "trapezoid");
            trapezoid.leg2 = GetSideLength("leg two", "trapezoid");
            trapezoid.height = GetSideLength("height", "trapezoid");
            return trapezoid;
        }

        public Circle BuildACircle()
        {
            var circle = new Circle();
            circle.radius = GetSideLength("radius", "circle");
            return circle;
        }
    }
}
