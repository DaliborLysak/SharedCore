namespace Core.Providers
{
    public interface IDialogProvider
    {
        IDialogData ShowDialog(IDialogData data);
        IDialogData ShowDialog(ProviderTypes.DialogType dialogType, ProviderTypes.ExtensionType extensionType);
    }
}
