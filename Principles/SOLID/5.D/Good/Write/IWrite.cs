namespace SOLID._5.D.Good.Write
{
    /// <summary>
    /// For writing
    /// </summary>
    internal interface IWrite
    {
        /// <summary>
        /// Write the value
        /// </summary>
        /// <param name="value">The value</param>
        void Write(double value);

        /// <summary>
        /// Write the message
        /// </summary>
        /// <param name="message">The message</param>
        void Write(string message);
    }
}
