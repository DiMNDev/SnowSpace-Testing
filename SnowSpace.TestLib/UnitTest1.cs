using FluentAssertions;
using SnowSpace.ClassLib;

namespace SnowSpace.TestLib;

public class RocketTesting
{
    [Fact]
    public void WhenRocketTakesOffItDoesNotBlowUp()
    {
        //Arrange
var rocket = new RocketShip("DragonOne");
        //Act
    var result = rocket.Takeoff();
        //Assert
        result.Should().NotBe("BLOWED UP!");
    }
}