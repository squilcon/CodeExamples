namespace Examples.Principles.SOLID._5.D.Good.Write
{
    /// <summary>
    /// For writing to file
    /// </summary>
    internal class WriteFile : IWrite
    {
        /// <inheritdoc/>
        public void Write(double value)
        {
            Write(value.ToString());
        }

        /// <inheritdoc/>
        public void Write(string message)
        {
            File.AppendAllText("File path", message);
        }
    }
}
