namespace BinaryGap.Tests;

using Xunit;

public class UnitTest1
{
    [Fact]
    public void BinaryGapSolution_DetectsGaps()
    {
        Assert.Equal(2, BinaryGap.Solution.DetectGap(9)); // 1001
        Assert.Equal(4, BinaryGap.Solution.DetectGap(529)); // 1000010001
        Assert.Equal(1, BinaryGap.Solution.DetectGap(20)); // 10100
        Assert.Equal(0, BinaryGap.Solution.DetectGap(15)); // 1111
        Assert.Equal(0, BinaryGap.Solution.DetectGap(32)); // 100000

        Assert.Equal(3, BinaryGap.Solution.DetectGap(145)); // 10010001
    }
}