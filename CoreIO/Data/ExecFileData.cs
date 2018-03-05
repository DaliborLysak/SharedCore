using Core.Providers;
using System;

namespace CoreIO.Data
{
    public class ExecFileData : FileManipulationData
    {
        public ExecFileData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Exec;
        }

        public bool Wait { get; set; } = false;
        public string FileArgument { get; set; } = String.Empty;
    }
}
