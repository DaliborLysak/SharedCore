using Core.Providers;
using System;

namespace CoreIO.Manipulation
{
    internal class FileDataProcess
    {
        protected IFileManipulationData Manipulate<T>(IFileManipulationData data, ProviderTypes.DialogType dialogType) where T : IFileManipulationData
        {
            if (String.IsNullOrEmpty(data?.FileName) && (data.DialogProvider != null))
            {
                // pokud neni file name, zobrazi se dialog
                data.FileName = data?.DialogProvider?.ShowDialog(dialogType, data.Extension).Uri;
            }

            if (!String.IsNullOrEmpty(data.FileName))
            {
                data.ProcessFileData();
            }

            return data;
        }
    }
}
