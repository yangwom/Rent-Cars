using RentCars.Types;
using FluentAssertions;

namespace RentCars.Test;

public class TestEnums
{
    [Theory]
    [InlineData(1, "Chamber")]
    [InlineData(2, "Disc")]
    [InlineData(3, "Drum")]
    public void BreakeTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        BrakeType Types = (BrakeType)valueEntry;
        Types.ToString().Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(0, "FrontWheelDrive")]
    [InlineData(1, "RearWheelDrive")]
    [InlineData(2, "AllWheelDrive")]
    public void TractionTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        TractionType Type = (TractionType)valueEntry;

        Type.ToString().Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(10, "Alcohol")]
    [InlineData(20, "Gasoline")]
    [InlineData(30, "Flex")]
    [InlineData(40, "Diesel")]
    [InlineData(50, "Electric")]
    [InlineData(60, "Hybrid")]
    public void FuelTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        FuelType Type = (FuelType)valueEntry;

        Type.ToString().Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(0, "Confirmed")]
    [InlineData(1, "Finished")]
    public void RentStatusShouldHaveCorrectValues(int valueEntry, string expected)
    {
        RentStatus Type = (RentStatus)valueEntry;
        Type.ToString().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void RentStatusFinishedShouldBeTheSameValueAsCancelled()
    {
       RentStatus.Finished.Should().Be(RentStatus.Cancelled);
    }
}
