using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Logic
{
    internal class LogicFactory
    {
        public ILogic Instantiate(Shape shape)
        {
            return shape.Type switch
            {
                ShapeType.Square => new SquareLogic((Square)shape),
                ShapeType.Circle => new CircleLogic((Circle)shape),
                ShapeType.Rectangle => new RectangleLogic((Rectangle)shape),
                _ => throw new NotImplementedException()
            };
        }
    }
}
