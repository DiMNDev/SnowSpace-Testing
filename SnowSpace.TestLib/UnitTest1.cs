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

    [Fact]
    public void CanChangeName()
    {
        // Given
        var rocket = new RocketShip("Original1");
        // When
        rocket.SetName("Changed1");
        // Then
        rocket.GetName().Should().Be("Changed1");
    }

    [Fact]
    public void CannotMakeNullName()
    {
        // Given
        void makeRocketWithNullName()
        {
            var rocket = new RocketShip(null);
        }
        // When
        FluentActions
        .Invoking(makeRocketWithNullName)
        .Should()
        .Throw<Exception>();
        // Then

    }


    [Fact]
    public void RocektWithNoNumberThrowsException()
    {
        // Given
        void makeRocketWithoutNumber()
        {
            var rocket = new RocketShip("NoNumberInName");
        }
        // When
        FluentActions.Invoking(makeRocketWithoutNumber).Should().Throw<Exception>();
        // Then
    }
}