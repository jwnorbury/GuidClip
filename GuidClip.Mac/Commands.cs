using System;
using System.Diagnostics;

namespace GuidClip.Mac
{
    public static class Commands
    {
        public static void PbCopy(string text)
        {
            var shell = Environment.GetEnvironmentVariable("SHELL");
            var processInfo = new ProcessStartInfo(shell, $"-c \"echo '{text}' | pbcopy\"");
            processInfo.UseShellExecute = true;
            var process = new Process();
            process.StartInfo = processInfo;
            _ = process.Start();
        }
    }
}