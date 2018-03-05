using System.IO;
using Core.Providers;

namespace CoreIO.Data
{
    public class LoadStreamData : FileManipulationData
    {
        public LoadStreamData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Load;
        }

        public Stream Stream { get; set; }

        protected override void ProcessFile()
        {
            base.ProcessFile();

            Stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
        }
    }
}
