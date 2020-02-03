namespace GuidClip.Mac
{
    class Program
    {
        static void Main(string[] args)
        {
            var guidWriter = new GuidWriterMacClipboard();
            guidWriter.Generate(args);
        }
    }
}
