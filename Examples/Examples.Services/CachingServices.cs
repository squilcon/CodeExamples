using Microsoft.Extensions.Caching.Memory;
using Examples.Core.Interfaces.Services;

namespace Examples.Services
{
    /// <summary>
    /// Offer caching services
    /// </summary>
    internal class CachingServices : ICachingServices
    {
        private readonly IMemoryCache _memoryCache;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="memoryCache">IMemoryCache dependency</param>
        public CachingServices(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        /// <inheritdoc/>
        public string GetExampleValue(string valueToCache)
        {
            const string cacheKey = "key";
            if (!_memoryCache.TryGetValue(cacheKey, out string cachedValue))
            {
                _memoryCache.Set(cacheKey, valueToCache, TimeSpan.FromMinutes(1));
            }

            return cachedValue;
        }
    }
}
