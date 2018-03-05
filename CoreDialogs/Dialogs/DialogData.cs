using Core.Providers;
using System;

namespace CoreDialogs.Dialogs
{
    public class DialogData : IDialogData
    {
        public ProviderTypes.DialogType DialogShowType { get; set; }
        public DialogFilter DialogFilter { get; set; } = new DialogFilter();
        public string Uri { get; set; } = String.Empty;
    }
}
