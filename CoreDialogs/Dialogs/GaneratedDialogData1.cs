using Core.Providers;

namespace CoreDialogs.Dialogs
{
    public class SaveDialog : DialogData
    {
        public SaveDialog()
        {
            DialogShowType = ProviderTypes.DialogType.Save;
        }
    }

    public class OpenDialog : DialogData
    {
        public OpenDialog()
        {
            DialogShowType = ProviderTypes.DialogType.Open;
        }
    }

    public class FolderDialog : DialogData
    {
        public FolderDialog()
        {
            DialogShowType = ProviderTypes.DialogType.Folder;
        }
    }

}