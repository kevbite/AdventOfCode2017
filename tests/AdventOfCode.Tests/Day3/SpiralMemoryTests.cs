using AdventOfCode.Day3;
using Microsoft.Win32.SafeHandles;
using Xunit;

namespace AdventOfCode.Tests.Day3
{
    public class SpiralMemoryTests
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(12, 3)]
        [InlineData(23, 2)]
        [InlineData(1024, 31)]
        public void ShouldReturnCorrectSteps(int input, int expected)
        {
            var spiralMemory = new SpiralMemory();

            var result = spiralMemory.GetSteps(input);
            
            Assert.Equal(expected, result);
        }
    }
}