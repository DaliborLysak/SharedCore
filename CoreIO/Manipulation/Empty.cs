using Core.Providers;
using Core.Exceptions;

namespace CoreIO.Manipulation
{
    internal class Empty : IFileManipulationMethod
    {
        public IFileManipulationData Manipulate<T>(IFileManipulationData data) where T : IFileManipulationData
        {
            throw new EmptyCallInProviderException($"{nameof(data.DialogProvider)} has empty method.");
        }
    }
}
