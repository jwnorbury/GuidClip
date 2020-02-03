using System;

namespace GuidClip.Windows
{
    class Program 
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var guidWriter = new GuidWriterWindowsClipboard();
            guidWriter.Generate(args);
        }
    }
}
