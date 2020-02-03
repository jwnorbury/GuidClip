using System;
using System.Text;

namespace GuidClip.Core
{
    /// <summary>
    /// Class to generate GUIDs
    /// </summary>
    public class GuidGenerator
    {
        const int GUID_LENGTH = 36;

        private static int _newLineLength = int.MinValue;
        private static int NewLineLength
        {
            get
            {
                if (_newLineLength == int.MinValue)
                {
                    _newLineLength = Environment.NewLine.Length;
                }
                return _newLineLength;
            }
        }

        /// <summary>
        /// Generate a single GUID.
        /// </summary>
        /// <returns>String of generated GUID.</returns>
        public static string GenerateGuid() =>
            Guid.NewGuid().ToString();

        /// <summary>
        /// Generate multiple GUIDs.
        /// </summary>
        /// <param name="numGuids">Number of GUIDs to generate.</param>
        /// <returns>String of GUIDs separated by a new line.</returns>
        public static string GenerateMultipleGuids(int numGuids)
        {
            if (numGuids <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Number of GUIDs to generate must be greater that 0.");
            }

            if (numGuids == 1)
            {
                return GenerateGuid();
            }

            var capacity = (numGuids * GUID_LENGTH)
                + (numGuids * NewLineLength);
            var sb = new StringBuilder(capacity);
            for (var i = 0; i < numGuids; i++)
            {
                sb.AppendLine(GenerateGuid());
            }

            return sb.ToString(0, capacity - NewLineLength);
        }
    }
}
