using FluentAssertions;

namespace CodeQualityDemo.Test;

public class CoverageDemoTest
{
    [Theory]
    [InlineData(true, "Bla da")]
    [InlineData(false, "Bla")]
    [InlineData(false, "Bla")]
    public void MethodReturningAString_WhenRunThenResultReturned(bool doIt, string exptectedResult)
    {
        // Arrange
        var sut = new CoverageDemo();
        
        // Act
        var actualResult = sut.MethodReturningAString(doIt);

        // Assert
        actualResult.Should().Be(exptectedResult);

    }
}