namespace SOLID._5.D.Good.Write
{
    /// <summary>
    /// Factory for choosing where to write
    /// </summary>
    internal interface IWriteFactory
    {
        /// <summary>
        /// Write to console
        /// </summary>
        /// <returns>An instance</returns>
        IWrite Console();

        /// <summary>
        /// Write to file
        /// </summary>
        /// <returns>An instance</returns>
        IWrite File();
    }
}