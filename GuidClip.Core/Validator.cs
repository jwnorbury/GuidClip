using System;

namespace GuidClip.Core
{
    public static class Validator
    {
        /// <summary>
        /// Parse args array for number of GUIDs to generate.
        /// </summary>
        /// <returns>Number of GUIDs to generate.</returns>
        public static int GetNumGuidsToGenerate(string[] args)
        {
            if (args is null || args.Length == 0)
            {
                // When no arguments supplied, generate a single GUID.
                return 1;
            }
            else if (args.Length == 1 && int.TryParse(args[0], out var numGuids))
            {
                return numGuids;
            }
            else if (args.Length == 1)
            {
                throw new FormatException("Expected argument to be an integer.");
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "If provided, argument must be greater than 0.");
            }
        }

    }
}