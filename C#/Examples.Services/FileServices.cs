using Examples.Core.Interfaces.Services;
using Examples.Core.Models.Enums;
using Microsoft.AspNetCore.StaticFiles;

namespace Examples.Services
{
    /// <summary>
    /// Offer filefonctionalities
    /// </summary>
    internal class FileServices : IFileServices
    {
        private readonly IContentTypeProvider _contentTypeProvider;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contentTypeProvider">IContentTypeProvider dependency</param>
        /// <remarks>
        /// I don't know if it's correct to use this interface within the DI since every 
        /// exemple I see always use the concrete implementation "FileExtensionContentTypeProvider".
        /// It's kinda usefull to use it this way when you need to unit test a function without 
        /// having to care about what value is needed to get the expected result.
        /// </remarks>
        public FileServices(IContentTypeProvider contentTypeProvider)
        {
            _contentTypeProvider = contentTypeProvider;
        }

        /// <inheritdoc/>
        public bool ValidFileSignature(byte[] fileContent, FileType fileType)
        {
            var hexContent = BitConverter.ToString(fileContent);
            return fileType switch
            {
                var x when x.Equals(FileType.JPEG) ||
                           x.Equals(FileType.JPG) => hexContent.StartsWith("FF-D8"),
                FileType.PNG => hexContent.StartsWith("89-50-4E-47-0D-0A-1A-0A"),
                FileType.PDF => hexContent.StartsWith("25-50-44-46-2D"),
                _ => false
            };
        }

        /// <inheritdoc/>
        public string GetContentType(string fileExtension)
        {
            if (!fileExtension.StartsWith("."))
            {
                fileExtension = $".{fileExtension}";
            }

            if (!_contentTypeProvider.TryGetContentType(fileExtension, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            return contentType;
        }
    }
}
