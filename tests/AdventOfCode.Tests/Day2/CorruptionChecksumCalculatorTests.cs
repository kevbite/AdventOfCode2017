using AdventOfCode.Day2;
using Xunit;

namespace AdventOfCode.Tests.Day2
{
    public class CorruptionChecksumCalculatorTests
    {
        [Fact]
        public void ShouldReturnCorrectChecksum()
        {
            var input = @"5	1	9	5
7	5	3
2	4	6	8";

            var sut = new CorruptionChecksumCalculator();

            var output = sut.Calculate(input);

            Assert.Equal(18, output);
        }

        [Fact]
        public void ShouldReturnSumOfEvenlyDivisibleValues()
        {
            var input = @"5	9	2	8
9	4	7	3
3	8	6	5";

            var sut = new CorruptionChecksumCalculator();

            var output = sut.GetSumOfEvenlyDivisibleValues(input);

            Assert.Equal(9, output);
        }
    }
}