using System;

namespace GuidClip.Core
{
    public static class Validator
    {
        public static int GetNumberOfGuids(string[] args)
        {
            if (args is null || args.Length == 0)
            {
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