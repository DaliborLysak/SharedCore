namespace Core.Providers
{
    public interface IFileManipulationData
    {
        ProviderTypes.FileManipulationOperationType Method { get; }
        ProviderTypes.ExtensionType Extension { get; }
        IDialogProvider DialogProvider { get; }
        string FileName { get; set; }

        void ProcessFileData();
    }
}
