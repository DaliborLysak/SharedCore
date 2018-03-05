using Core.Providers;

namespace CoreIO
{
    public interface IFileManipulationMethod
    {
        IFileManipulationData Manipulate<T>(IFileManipulationData data) where T : IFileManipulationData;
    }
}
