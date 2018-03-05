using Core.Providers;
using System.Collections.Generic;

namespace CoreDialogs.Dialogs
{
    public class DialogProvider : IDialogProvider
    {
        public DialogProvider()
        {
            DialogShowings = new Dictionary<ProviderTypes.DialogType, IDialogShowing>()
            {
                [ProviderTypes.DialogType.Folder] = new ShowFolderDialog(),
                [ProviderTypes.DialogType.Open] = new ShowOpenDialog(),
                [ProviderTypes.DialogType.Save] = new ShowSaveDialog()
            };
        }

        private Dictionary<ProviderTypes.DialogType, IDialogShowing> DialogShowings;

        public IDialogData ShowDialog(IDialogData data)
        {
            IDialogData result = null;
            if (DialogShowings.ContainsKey(data.DialogShowType))
            {
                result = DialogShowings[data.DialogShowType]?.Show(data);
            }

            return result;
        }

        private Dictionary<ProviderTypes.ExtensionType, DialogFilter> ExtensionDialogTranslation = new Dictionary<ProviderTypes.ExtensionType, DialogFilter>()
        {
            [ProviderTypes.ExtensionType.Json] = new DialogJsonFilter(),
            [ProviderTypes.ExtensionType.Text] = new DialogTextFilter(),
            [ProviderTypes.ExtensionType.Xml] = new DialogXmlFilter()
        };

        public IDialogData ShowDialog(ProviderTypes.DialogType dialogType, ProviderTypes.ExtensionType extensionType)
        {
            IDialogData data = new DialogData()
            {
                DialogShowType = dialogType,
                DialogFilter = ExtensionDialogTranslation.ContainsKey(extensionType) ? ExtensionDialogTranslation[extensionType] : null
            };
            if (DialogShowings.ContainsKey(data.DialogShowType))
            {
                data = DialogShowings[data.DialogShowType]?.Show(data);
            }

            return data;
        }
    }
}
