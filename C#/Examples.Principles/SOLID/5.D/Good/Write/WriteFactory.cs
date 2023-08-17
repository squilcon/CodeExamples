namespace Examples.Principles.SOLID._5.D.Good.Write
{
    /// <summary>
    /// Factory for choosing where to write
    /// </summary>
    internal class WriteFactory : IWriteFactory
    {
        /// <inheritdoc/>
        public IWrite Console()
        {
            return new WriteConsole();
        }

        /// <inheritdoc/>
        public IWrite File()
        {
            return new WriteFile();
        }
    }
}
