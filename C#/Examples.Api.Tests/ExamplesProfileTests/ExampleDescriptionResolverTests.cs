using Examples.Api.Models.Enums;
using Examples.Api.Models;
using Examples.Api.Tests.ExamplesProfileTests.Base;

namespace Examples.Api.Tests.ExamplesProfileTests
{
    /// <summary>
    /// Unit tests for the Resolve method of the ExampleDescriptionResolver class
    /// </summary>
    public class ExampleDescriptionResolverTests : ExamplesProfileBaseTest
    {
        /// <summary>
        /// Verify the method does the expected logic / generate the expected result
        /// </summary>
        [Fact]
        public void Resolve_ValueLanguageOne_ResolveWithLanguageOneDescription()
        {
            //Arrange
            var value = Fixture.Build<ExampleValueTwo>()
                               .With(x => x.Language, LanguageType.LanguageOne)
                               .Create();

            //Act
            var result = Mapper.Map<ExampleValueTwoMapped>(value);

            //Assert
            Assert.Equal(value.DescriptionLanguageOne, result.Description);
        }

        /// <summary>
        /// Verify the method does the expected logic / generate the expected result
        /// </summary>
        [Fact]
        public void Resolve_ValueLanguageTwo_ResolveWithLanguageTwoDescription()
        {
            //Arrange
            var value = Fixture.Build<ExampleValueTwo>()
                               .With(x => x.Language, LanguageType.LanguageTwo)
                               .Create();

            //Act
            var result = Mapper.Map<ExampleValueTwoMapped>(value);

            //Assert
            Assert.Equal(value.DescriptionLanguageTwo, result.Description);
        }
    }
}
