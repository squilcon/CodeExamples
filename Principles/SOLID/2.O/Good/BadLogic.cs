using SOLID._2.O.Good.Formulas;
using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Write;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good
{
    internal class BadLogic
    {
        public void Execute()
        {
            var shapes = new List<Shape>()
            {
                { new Square(2) },
                { new Circle(4) },
                { new Rectangle(4, 2) }
            };

            foreach (var shape in shapes)
            {
                var area = new CalculateFactory().Instantiate(shape).Area();
                                
                if (shape.Type.Equals(ShapeType.Circle))
                {
                    new WriteFactory().Instantiate(WriteType.Console).WriteLog(area);
                }
                else
                {
                    new WriteFactory().Instantiate(WriteType.File).WriteLog(area);
                }
            }
        }
    }
}
