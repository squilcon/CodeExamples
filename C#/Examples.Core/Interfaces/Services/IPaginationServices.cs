namespace Examples.Core.Interfaces.Services
{
    /// <summary>
    /// Offer pagination functions
    /// </summary>
    public interface IPaginationServices
    {
        /// <summary>
        /// Paginate a list of elements
        /// </summary>
        /// <typeparam name="T">The type of elements</typeparam>
        /// <param name="source">The source list</param>
        /// <param name="page">The page to return</param>
        /// <param name="numberPerPage">The number of elements per page</param>
        /// <returns>The paginated list</returns>
        IEnumerable<T> Paginate<T>(IEnumerable<T> source, int? page, int? numberPerPage);
    }
}