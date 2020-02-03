using System;

namespace GuidClip.Core
{
    public abstract class GuidWriterBase
    {
        public void Generate(string[] args)
        {
            var numGuids = Validator.GetNumberOfGuids(args);
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

        public abstract void SetSingleGuid();
        
        public abstract void SetMultipleGuids(int numGuids);
    }
}