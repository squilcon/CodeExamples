using SOLID._5.D.Good.Enums;

namespace SOLID._5.D.Good.Models
{
    /// <summary>
    /// A rectangle
    /// </summary>
    internal class Rectangle : Polygon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="length">The length of a side</param>
        /// <param name="width">The width of a side</param>
        public Rectangle(int length, int width)
        {
            Type = ShapeType.Rectangle;
            Length = length;
            Width = width;
            NumberOfSides = 4;
        }

        /// <summary>
        /// The length of a side
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// The width of a side
        /// </summary>
        public int Width { get; set; }
    }
}
