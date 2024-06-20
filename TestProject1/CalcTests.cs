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
}