namespace Examples.Principles.SOLID._5.D.Good.Write
{
    /// <summary>
    /// For writing to console
    /// </summary>
    internal class WriteConsole : IWrite
    {
        /// <inheritdoc/>
        public void Write(double value)
        {
            Write(value.ToString());
        }

        /// <inheritdoc/>
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
