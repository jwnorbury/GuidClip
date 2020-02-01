using System;
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
    }
}
