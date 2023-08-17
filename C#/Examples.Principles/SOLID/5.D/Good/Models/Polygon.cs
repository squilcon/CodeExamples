namespace Examples.Principles.SOLID._5.D.Good.Models
{
    /// <summary>
    /// A polygon
    /// </summary>
    internal abstract class Polygon : Shape
    {
        /// <summary>
        /// The number of sides
        /// </summary>
        public int NumberOfSides { get; set; }
    }
}
