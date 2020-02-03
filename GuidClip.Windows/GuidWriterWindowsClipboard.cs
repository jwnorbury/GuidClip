using System.Windows;
using GuidClip.Core;

namespace GuidClip.Windows
{
    public class GuidWriterWindowsClipboard : GuidWriterBase
    {
        public override void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Clipboard.SetText(guidText);
        }

        public override void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Clipboard.SetText(guidText);
        }

    }
}