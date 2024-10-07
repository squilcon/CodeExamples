using SOLID._5.D.Good.Enums;

namespace SOLID._5.D.Good.Models
{
    /// <summary>
    /// A circle
    /// </summary>
    internal class Circle : Shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="radius">The radius</param>
        public Circle(int radius)
        {
            Type = ShapeType.Circle;
            Radius = radius;
        }

        /// <summary>
        /// The radius
        /// </summary>
        public int Radius { get; set; }
    }
}
