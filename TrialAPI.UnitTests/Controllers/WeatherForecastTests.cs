using Microsoft.Extensions.Logging;
using NSubstitute;
using Shouldly;
using TrialAPI.Controllers;

namespace TrialAPI.UnitTests.Controllers;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_Returns_A_Forecast()
    {
        // Arrange
        var fakeLogger = Substitute.For<ILogger<WeatherForecastController>>();

        // Act
        var result = new WeatherForecastController(fakeLogger).Get();

        // Assert
        result.Count().ShouldBe(5);
    }
}
