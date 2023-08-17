using Examples.Principles.SOLID._2.O.Good.Models;
using Examples.Principles.SOLID._2.O.Good.Logic;

namespace Examples.Principles.SOLID._2.O.Good
{
    internal class GoodLogic
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
                new LogicFactory().Instantiate(shape).Execute();
            }
        }
    }
}
