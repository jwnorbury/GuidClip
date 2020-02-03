using System;
using GuidClip.Core;

namespace GuidClip.Linux
{
    /// <summary>
    /// GUID writer to target STDOUT as this can easily be
    /// piped to the desired clipboard program. *NIX 
    /// OS do not have a universal clipboard.
    /// </summary>
    public class GuidWriterStdOut : GuidWriterBase
    {
        /// <summary>
        /// Write single GUID to STDOUT.
        /// </summary>
        public override void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Console.WriteLine(guidText);
        }

        /// <summary>
        /// Write specified number of GUIDs to STDOUT.
        /// </summary>
        /// <param name="numGuids">Number of GUIDs to generate.</param>
        public override void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Console.WriteLine(guidText);
        }
    }
}