using Core.Providers;
using CoreIO.Data;
using System.IO;
using System.Linq;

namespace CoreIO.Manipulation
{
    internal class Copy : IFileManipulationMethod
    {
        public IFileManipulationData Manipulate<T>(IFileManipulationData data) where T : IFileManipulationData
        {
            var fromTo = (data as CopyFileData)?.FromTo;
            var targetFolders = fromTo.Select(f => Path.GetDirectoryName(f.Item2));
            foreach (var folder in targetFolders)
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }
            fromTo.ForEach(ft => File.Copy(ft.Item1, ft.Item2, true));
            return data;
        }
    }
}
