using AutoMapper;
using Examples.Api.Models;
using Examples.Api.Models.Enums;

namespace Examples.Api.AutoMapperProfile.Converter
{
    public class ExampleGroupByConverter : ITypeConverter<IEnumerable<ExampleValue>, IEnumerable<ExampleValueGrouped>>
    {
        public IEnumerable<ExampleValueGrouped> Convert(IEnumerable<ExampleValue> source, IEnumerable<ExampleValueGrouped> destination, ResolutionContext context)
        {
            return source.GroupBy(x => x.Value)
                         .Select(y => new ExampleValueGrouped
                         {
                             Id = y.Key,
                             DescriptionLanguageOne = y.FirstOrDefault(x => x.Language.Equals(LanguageType.LanguageOne))?.Description ?? string.Empty,
                             DescriptionLanguageTwo = y.FirstOrDefault(x => x.Language.Equals(LanguageType.LanguageTwo))?.Description ?? string.Empty
                         });
        }
    }
}
