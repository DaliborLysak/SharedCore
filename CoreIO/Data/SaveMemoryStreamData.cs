using Core.Providers;
using System.IO;

namespace CoreIO.Data
{
    public class SaveMemoryStreamData : FileManipulationData
    {
        public SaveMemoryStreamData()
        {
            Method = ProviderTypes.FileManipulationOperationType.Save;
        }

        public MemoryStream MemoryStream { get; set; }

        protected override void ProcessFile()
        {
            base.ProcessFile();

            if (MemoryStream != null)
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    MemoryStream.Position = 0;
                    MemoryStream.CopyTo(fs);
                }
            }
        }
    }
}
