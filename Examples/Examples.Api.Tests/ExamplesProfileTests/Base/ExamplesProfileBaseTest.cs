using AutoMapper;
using Examples.Api.AutoMapperProfile;
using Examples.Api.AutoMapperProfile.Converter;
using Examples.Api.AutoMapperProfile.Resolver;

namespace Examples.Api.Tests.ExamplesProfileTests.Base
{
    public abstract class ExamplesProfileBaseTest : BaseTest
    {
        protected static IMapper Mapper => new MapperConfiguration(option =>
        {
            option.AddProfile<ExamplesProfile>();
            option.ConstructServicesUsing(type =>
            {
                return type switch
                {
                    var x when x.Equals(typeof(ExampleGroupByConverter)) => new ExampleGroupByConverter(),
                    var x when x.Equals(typeof(ExampleDescriptionResolver)) => new ExampleDescriptionResolver(),
                    _ => null
                };
            });
        }).CreateMapper();
    }
}
