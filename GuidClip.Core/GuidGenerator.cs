using System;

namespace GuidClip.Core
{
    /// <summary>
    /// Class to generate GUIDs.
    /// </summary>
    public class GuidGenerator
    {
        /// <summary>
        /// Generate a single GUID.
        /// </summary>
        /// <returns>String of generated GUID.</returns>
        public static string GenerateGuid() =>
            Guid.NewGuid().ToString();   
    }
}
