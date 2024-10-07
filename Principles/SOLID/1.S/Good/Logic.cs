using SOLID._1.S.Good.Enums;
using SOLID._1.S.Good.Models;

namespace SOLID._1.S.Good
{
    internal class Logic
    {
        public void Execute()
        {
            var square = new Shape() { Length = 2, Type = ShapeType.Square };
            var circle = new Shape() { Length = 4, Type = ShapeType.Circle };
            var calculate = new Calculate();
            var squareArea = calculate.Area(square);
            var circleArea = calculate.Area(circle);

            var log = new Log();
            log.WriteLog(squareArea);
            log.WriteLog(circleArea);
        }
    }
}
