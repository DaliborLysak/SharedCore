using Core.Providers;
using System.IO;

namespace CoreIO.Data
{
    public class SaveTextData : TextData
    {
        public SaveTextData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Save;
        }

        protected override void ProcessFile()
        {
            base.ProcessFile();

            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.Write(StringData);
            }
        }
    }
}
