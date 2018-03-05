using Core.Providers;
using System;
using System.Collections.Generic;

namespace CoreIO.Data
{
    public class CopyFileData : FileManipulationData
    {
        public CopyFileData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Copy;
        }

        public List<Tuple<string, string>> FromTo { get; set; } = new List<Tuple<string, string>>(); // <from, to>
        public bool Overwrite { get; set; } = false;
    }
}
