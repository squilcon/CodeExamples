using Examples.Principles.SOLID._2.O.Bad.Enums;
using Examples.Principles.SOLID._2.O.Bad.Models;

namespace Examples.Principles.SOLID._2.O.Bad
{
    internal class Logic
    {
        public void Execute()
        {
            var square = new Shape() { Length = 2, Type = ShapeType.Square };
            var circle = new Shape() { Length = 4, Type = ShapeType.Circle };
            var rectangle = new Shape() { Length = 4, Width = 2, Type = ShapeType.Rectangle };
            var calculate = new Calculate();
            var squareArea = calculate.Area(square);
            var circleArea = calculate.Area(circle);
            var rectangleArea = calculate.Area(rectangle);

            var log = new Log();
            log.WriteLog(squareArea);
            log.WriteLog(circleArea, true);
            log.WriteLog(rectangleArea, true);
        }
    }
}
