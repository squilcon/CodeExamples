using SOLID._3.L.Bad.Models;

namespace SOLID._3.L.Bad
{
    internal class Logic
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
                if (shape.GetType() == typeof(Circle))
                {
                    var circle = (Circle)shape;
                    circle.CalculateCircumference();
                    //or
                    shape.CalculateCircumference();
                }
            }
        }
    }
}
