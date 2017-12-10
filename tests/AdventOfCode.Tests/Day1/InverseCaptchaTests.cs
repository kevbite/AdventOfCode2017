using AdventOfCode.Day1;
using System.IO;
using Xunit;

namespace AdventOfCode.Tests.Day1
{
    public class InverseCaptchaTests
    {
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        [InlineData("91212129", 9)]
        public void ShouldReturnCorrectValuesForSolve1(string input, int expected)
        {
            var reader = new StringReader(input);

            var sum = new InverseCaptcha().Solve1(reader);

            Assert.Equal(expected, sum);
        }

        [Theory]
        [InlineData("1212", 6)]
        [InlineData("1221", 0)]
        [InlineData("123425", 4)]
        [InlineData("123123", 12)]
        [InlineData("12131415", 4)]
        public void ShouldReturnCorrectValuesForSolve2(string input, int expected)
        {
            var sum = new InverseCaptcha().Solve2(input);

            Assert.Equal(expected, sum);
        }

    }
}
