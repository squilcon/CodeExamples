using SOLID._5.D.Good.Enums;

namespace SOLID._5.D.Good.Models
{
    /// <summary>
    /// A shape
    /// </summary>
    internal abstract class Shape
    {
        /// <summary>
        /// The type of shape
        /// </summary>
        public ShapeType Type { get; set; }
    }
}
