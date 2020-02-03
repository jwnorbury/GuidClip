using System;

namespace GuidClip.Core
{
    public abstract class GuidWriterBase
    {
        /// <summary>
        /// Generate GUIDs based on user input.
        /// </summary>
        /// <param name="args">Arguments passed in from command line.</param>
        public void Generate(string[] args)
        {
            var numGuids = Validator.GetNumGuidsToGenerate(args);
            if (numGuids == 1)
            {
                SetSingleGuid();
            }
            else if (numGuids > 1)
            {
                SetMultipleGuids(numGuids);
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Number of GUIDs to generate must be greater than 0.");
            }
        }

        /// <summary>
        /// Generate a single GUID and write to implemented location.
        /// </summary>
        public abstract void SetSingleGuid();

        /// <summary>
        /// Generate a specified number of GUIDs and write to implemented location.
        /// </summary>
        /// <param name="numGuids">Number of GUIDs to generate.</param>
        public abstract void SetMultipleGuids(int numGuids);
    }
}