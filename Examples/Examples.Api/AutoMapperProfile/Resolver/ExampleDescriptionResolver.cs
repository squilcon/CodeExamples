using AutoMapper;
using Examples.Api.Models;
using Examples.Api.Models.Enums;

namespace Examples.Api.AutoMapperProfile.Resolver
{
    public class ExampleDescriptionResolver : IValueResolver<ExampleValueTwo, ExampleValueTwoMapped, string>
    {
        public string Resolve(ExampleValueTwo source, ExampleValueTwoMapped destination, string member, ResolutionContext context)
        {
            return source.Language.Equals(LanguageType.LanguageOne) ? source.DescriptionLanguageOne : source.DescriptionLanguageTwo;
        }
    }
}
