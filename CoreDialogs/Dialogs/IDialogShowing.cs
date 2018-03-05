using Core.Providers;

namespace CoreDialogs.Dialogs
{
    public interface IDialogShowing
    {
        IDialogData Show(IDialogData data);
    }
}
