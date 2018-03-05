using Core.Providers;
using System.IO;

namespace CoreIO.Data
{
    public class LoadTextData : TextData
    {
        public LoadTextData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Load;
        }

        protected override void ProcessFile()
        {
            base.ProcessFile();

            using (StreamReader reader = new StreamReader(FileName))
            {
                StringData = reader.ReadToEnd();
            }
        }
    }
}
