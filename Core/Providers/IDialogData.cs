namespace Core.Providers
{
    public interface IDialogData
    {
        ProviderTypes.DialogType DialogShowType { get; }
        string Uri { get; }
    }
}
