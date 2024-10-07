using SOLID._5.D.Good.Enums;

namespace SOLID._5.D.Good.Models
{
    /// <summary>
    /// A square
    /// </summary>
    internal class Square : Polygon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="length">The length of a side</param>
        public Square(int length)
        {
            Type = ShapeType.Square;
            Length = length;
            NumberOfSides = 4;
        }

        /// <summary>
        /// The length of a side
        /// </summary>
        public int Length { get; set; }
    }
}
