using System.Windows;
using GuidClip.Core;

namespace GuidClip.Windows
{
    public class GuidWriterWindowsClipboard : GuidWriterBase
    {
        /// <summary>
        /// Write single GUID to Windows clipboard.
        /// </summary>
        public override void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Clipboard.SetText(guidText);
        }

        /// <summary>
        /// Write specified number of GUIDs to Windows clipboard.
        /// </summary>
        /// <param name="numGuids">Number of GUIDs to generate.</param>
        public override void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Clipboard.SetText(guidText);
        }

    }
}