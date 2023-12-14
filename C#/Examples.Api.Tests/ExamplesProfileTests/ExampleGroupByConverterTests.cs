using Examples.Api.Models;
using Examples.Api.Models.Enums;
using Examples.Api.Tests.ExamplesProfileTests.Base;

namespace Examples.Api.Tests.ExamplesProfileTests
{
    /// <summary>
    /// Unit tests for the Convert method of the ExampleGroupByConverter class
    /// </summary>
    public class ExampleGroupByConverterTests : ExamplesProfileBaseTest
    {
        /// <summary>
        /// Verify the method does the expected logic / generate the expected result
        /// </summary>
        [Fact]
        public void Convert_ValuesInDifferentLanguage_GroupedValues()
        {
            //Arrange
            var valueId = Fixture.Create<string>();
            var valueLanguageOne = Fixture.Create<string>();
            var valueLanguageTwo = Fixture.Create<string>();
            var values = new List<ExampleValue>()
            {
                new() { Value = valueId, Description = valueLanguageOne, Language = LanguageType.LanguageOne },
                new() { Value = valueId, Description = valueLanguageTwo, Language = LanguageType.LanguageTwo }
            };

            var expected = new List<ExampleValueGrouped>()
            {
                new() { Id = valueId, DescriptionLanguageOne = valueLanguageOne, DescriptionLanguageTwo = valueLanguageTwo }
            };

            //Act
            var result = Mapper.Map<IEnumerable<ExampleValueGrouped>>(values);

            //Assert
            Assert.Single(result);
            Assert.Equivalent(expected, result, true);

        }

        /// <summary>
        /// Verify the method does the expected logic / generate the expected result
        /// </summary>
        [Fact]
        public void Convert_ValuesInDifferentLanguageWithSomeWithoutTwoLanguage_GroupedValues()
        {
            //Arrange
            var valueId = Fixture.Create<string>();
            var valueIdTwo = Fixture.Create<string>();
            var valueIdThree = Fixture.Create<string>();
            var valueLanguageOne = Fixture.Create<string>();
            var valueLanguageTwo = Fixture.Create<string>();
            var values = new List<ExampleValue>()
            {
                new() { Value = valueId, Description = valueLanguageOne, Language = LanguageType.LanguageOne },
                new() { Value = valueId, Description = valueLanguageTwo, Language = LanguageType.LanguageTwo },
                new() { Value = valueIdTwo, Description = valueLanguageOne, Language = LanguageType.LanguageOne },
                new() { Value = valueIdThree, Description = valueLanguageTwo, Language = LanguageType.LanguageTwo }
            };

            var expected = new List<ExampleValueGrouped>()
            {
                new() { Id = valueId, DescriptionLanguageOne = valueLanguageOne, DescriptionLanguageTwo = valueLanguageTwo },
                new() { Id = valueIdTwo, DescriptionLanguageOne = valueLanguageOne, DescriptionLanguageTwo = string.Empty },
                new() { Id = valueIdThree, DescriptionLanguageOne = string.Empty, DescriptionLanguageTwo = valueLanguageTwo }
            };

            //Act
            var result = Mapper.Map<IEnumerable<ExampleValueGrouped>>(values);

            //Assert
            Assert.Equal(3, result.Count());
            Assert.Equivalent(expected, result, true);

        }
    }
}
