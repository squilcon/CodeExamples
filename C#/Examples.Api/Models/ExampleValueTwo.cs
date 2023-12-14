using Examples.Api.Models.Enums;

namespace Examples.Api.Models
{
    public class ExampleValueTwo
    {
        public string Value { get; set; } = string.Empty;
        public string DescriptionLanguageOne { get; set; } = string.Empty;
        public string DescriptionLanguageTwo { get; set; } = string.Empty;
        public LanguageType Language { get; set; }
    }
}
