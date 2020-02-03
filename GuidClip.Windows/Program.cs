using System;
using System.Windows;
using GuidClip.Core;

namespace GuidClip.Windows
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                SetSingleGuid();
            }
            else if (args.Length == 1)
            {
                if (!int.TryParse(args[0], out var numGuids))
                {
                    throw new FormatException("Expected argument to be an integer.");
                }
                else if (numGuids < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "If provided, argument must be greater than 0.");
                }

                SetMultipleGuids(numGuids);
            }
            else
            {
                throw new ArgumentException("Expected single integer or no arguments.");
            }
        }

        private static void SetSingleGuid()
        {
            var guidText = GuidGenerator.GenerateGuid();
            Clipboard.SetText(guidText);
        }

        private static void SetMultipleGuids(int numGuids)
        {
            var guidText = GuidGenerator.GenerateMultipleGuids(numGuids);
            Clipboard.SetText(guidText);
        }
    }
}
