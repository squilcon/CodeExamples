using SOLID._1.S.Bad.Enums;
using SOLID._1.S.Bad.Models;

namespace SOLID._1.S.Bad
{
    internal class Logic
    {
        public void Execute()
        {
            var square = new Shape() { Length = 2, Type = ShapeType.Square };
            var circle = new Shape() { Length = 4, Type = ShapeType.Circle };
            var calculate = new Calculate();
            calculate.Area(square);
            calculate.Area(circle);
        }
    }
}