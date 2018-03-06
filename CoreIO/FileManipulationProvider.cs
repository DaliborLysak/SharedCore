using Core.Providers;
using CoreIO.Manipulation;
using System.Collections.Generic;

namespace CoreIO
{
    public class FileManipulationProvider : IFileManipulationProvider
    {
        public FileManipulationProvider()
        {
            Methods = new Dictionary<ProviderTypes.FileManipulationOperationType, IFileManipulationMethod>()
            {
                [ProviderTypes.FileManipulationOperationType.Copy] = new Copy(),
                [ProviderTypes.FileManipulationOperationType.Exec] = new Execution(),
                [ProviderTypes.FileManipulationOperationType.Load] = new Load(),
                [ProviderTypes.FileManipulationOperationType.NotSet] = new Empty(),
                [ProviderTypes.FileManipulationOperationType.Save] = new Save()
            };
        }

        private Dictionary<ProviderTypes.FileManipulationOperationType, IFileManipulationMethod> Methods;

        public IFileManipulationData Process<T>(IFileManipulationData data) where T: IFileManipulationData
        {
            IFileManipulationData result = null;
            if (Methods.ContainsKey(data.Method))
            {
                result = Methods[data.Method]?.Manipulate<T>(data);
            }

            return result;
        }
    }
}
