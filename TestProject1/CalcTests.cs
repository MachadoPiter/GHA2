using FluentAssertions;
using GHA2.Service;

namespace GHATests;

public class CalcTests
{
    [Fact]
    public void TestAdd()
    {
        var calcService = new CalcService();
        calcService.Add(4, 5).Should().Be(9);
    }

    [Fact]
    public void TestSubtract()
    {
        var calcService = new CalcService();
        calcService.Subtract(9, 5).Should().Be(4);
    }

    [Fact]
    public void TestMultiply()
    {
        var calcService = new CalcService();
        calcService.Multiply(3, 4).Should().Be(12);
    }
}
