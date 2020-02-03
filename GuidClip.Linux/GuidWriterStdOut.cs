using System;
using GuidClip.Core;

namespace GuidClip.Linux
{
    public class GuidWriterStdOut : GuidWriterBase
    {
        public override void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Console.WriteLine(guidText);
        }

        public override void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Console.WriteLine(guidText);
        }
    }
}