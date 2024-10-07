using Examples.Core.Models.Enums;

namespace Examples.Core.Interfaces.Services
{
    /// <summary>
    /// Offer filefonctionalities
    /// </summary>
    public interface IFileServices
    {
        /// <summary>
        /// Get the content type based on the file extension
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>The content type</returns>
        string GetContentType(string fileExtension);

        /// <summary>
        /// Verify the file signature to see if it's valid based on the file type provided
        /// </summary>
        /// <param name="fileContent">The file content</param>
        /// <param name="fileType">The file type</param>
        /// <returns>If valid</returns>
        bool ValidFileSignature(byte[] fileContent, FileType fileType);
    }
}