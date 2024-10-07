using AutoMapper;
using Examples.Api.AutoMapperProfile.Converter;
using Examples.Api.AutoMapperProfile.Resolver;
using Examples.Api.Models;

namespace Examples.Api.AutoMapperProfile
{
    public class ExamplesProfile : Profile
    {
        public ExamplesProfile()
        {
            CreateMap<IEnumerable<ExampleValue>, IEnumerable<ExampleValueGrouped>>()
                .ConvertUsing<ExampleGroupByConverter>();

            CreateMap<ExampleValueTwo, ExampleValueTwoMapped>()
                .ForMember(destination => destination.Value, action => action.MapFrom(source => source.Value))
                .ForMember(destination => destination.Description, action => action.MapFrom<ExampleDescriptionResolver>());
        }
    }
}
