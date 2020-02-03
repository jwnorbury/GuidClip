using System;
using GuidClip.Core;

namespace GuidClip.Mac
{
    public class GuidWriterMacClipboard : GuidWriterBase
    {
        public override void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Commands.PbCopy(guidText);
        }

        public override void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Commands.PbCopy(guidText);
        }
    }
}