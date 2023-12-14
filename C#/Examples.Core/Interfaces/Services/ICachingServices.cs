namespace Examples.Core.Interfaces.Services
{
    /// <summary>
    /// Offer caching services
    /// </summary>
    public interface ICachingServices
    {
        /// <summary>
        /// Get the value entered in the last minute
        /// </summary>
        /// <param name="valueToCache">The value to cache</param>
        /// <returns>The cached value from the last minute</returns>
        string GetExampleValue(string valueToCache);
    }
}