using System;
using System.Linq;
using Xunit;

namespace GuidClip.Core.Tests
{
    public class GuidGeneratorTests
    {
        [Fact]
        public void GenerateGuid_Valid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Assert.True(Guid.TryParse(guidText, out _));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void GenerateMultipleGuids_Valid(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            var guids = guidText.Split(Environment.NewLine);
            var allGuidsValid = guids.All(x => Guid.TryParse(x, out _));
            Assert.True(allGuidsValid);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void GenerateMultipleGuids_Zero_OutOfRange(int numGuids)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => GuidGenerator.GenerateMultipleGuids(numGuids));
        }
    }
}
