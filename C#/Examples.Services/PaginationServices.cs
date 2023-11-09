using Examples.Core.Interfaces.Services;

namespace Examples.Services
{
    /// <summary>
    /// Offer pagination functions
    /// </summary>
    internal class PaginationServices : IPaginationServices
    {
        /// <inheritdoc/>
        public IEnumerable<T> Paginate<T>(IEnumerable<T> source, int? page, int? numberPerPage)
        {
            page ??= 0;
            numberPerPage ??= int.MaxValue;
            return source.Skip((page.Value - 1) * numberPerPage.Value).Take(numberPerPage.Value);
        }
    }
}
