using Core.Providers;
using System.Text;

namespace CoreIO.Data
{
    public class FileManipulationData : IFileManipulationData
    {
        public ProviderTypes.ExtensionType Extension { get; set; } = ProviderTypes.ExtensionType.Undefined;
        public IDialogProvider DialogProvider { get; set; }
        public string FileName { get; set; }

        public ProviderTypes.FileManipulationOperationType Method { get; protected set; } = ProviderTypes.FileManipulationOperationType.NotSet;

        public void ProcessFileData()
        {
            ProcessFile();
        }

        protected virtual void ProcessFile()
        {
        }
    }
}
