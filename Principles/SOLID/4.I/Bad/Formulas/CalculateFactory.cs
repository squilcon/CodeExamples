using SOLID._4.I.Bad.Enums;
using SOLID._4.I.Bad.Models;

namespace SOLID._4.I.Bad.Formulas
{
    internal class CalculateFactory
    {
        public ICalculate Instantiate(Shape shape)
        {
            return shape.Type switch
            {
                ShapeType.Square => new CalculateSquare((Square)shape),
                ShapeType.Circle => new CalculateCircle((Circle)shape),
                ShapeType.Rectangle => new CalculateRectangle((Rectangle)shape),
                _ => throw new NotImplementedException()
            };
        }
    }
}
