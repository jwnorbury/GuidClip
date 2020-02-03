using System;
using GuidClip.Core;

namespace GuidClip.Linux
{
    class Program
    {
        public static void Main(string[] args)
        {
            var guidWriter = new GuidWriterStdOut();
            guidWriter.Generate(args);
        }
    }
}
