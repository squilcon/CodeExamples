using Examples.Api.Models.Enums;

namespace Examples.Api.Models
{
    public class ExampleValue
    {
        public string Value { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public LanguageType Language { get; set; }
    }
}
