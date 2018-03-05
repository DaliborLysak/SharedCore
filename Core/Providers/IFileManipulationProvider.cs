namespace Core.Providers
{
    public interface IFileManipulationProvider
    {
        IFileManipulationData Process<T>(IFileManipulationData data) where T : IFileManipulationData;
    }
}
