using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Formulas
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
