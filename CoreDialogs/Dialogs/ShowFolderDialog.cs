using Core.Providers;
using System.Windows.Forms;

namespace CoreDialogs.Dialogs
{
    internal class ShowFolderDialog : IDialogShowing
    {
        public IDialogData Show(IDialogData data)
        {
            var dialogData = data as DialogData;
            if (dialogData != null)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                using (dialog)
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        dialogData.Uri = dialog.SelectedPath;
                    }
                }
            }

            return data;
        }
    }
}
