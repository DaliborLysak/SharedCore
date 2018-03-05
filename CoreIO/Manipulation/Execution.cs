using Core.Providers;
using CoreIO.Data;

namespace CoreIO.Manipulation
{
    internal class Execution : IFileManipulationMethod
    {
        public IFileManipulationData Manipulate<T>(IFileManipulationData data) where T: IFileManipulationData
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process() { EnableRaisingEvents = false };
            ExecFileData execFileData = data as ExecFileData;
            if (data != null)
            {
                process.StartInfo.Arguments = execFileData.FileArgument;
                process.StartInfo.FileName = execFileData.FileName;

                process.Start();

                if (execFileData.Wait)
                {
                    process.WaitForExit();
                }
            }

            return data;
        }
    }
}
