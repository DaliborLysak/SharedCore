using Core.Providers;
using System.Windows.Forms;

namespace CoreDialogs.Dialogs
{
    internal class DialogShowing : IDialogShowing
    {
        public DialogData Data { get; set; }

        public IDialogData Show(IDialogData data)
        {
            Data = data as DialogData;
            ProcessFileDialog();
            return Data;
        }

        public virtual void ProcessFileDialog()
        {
        }

        protected void ProcessFileDialog<T>() where T : FileDialog, new()
        {
            if (Data != null)
            {
                T dialog = new T();
                dialog.Filter = Data.DialogFilter.Filter;
                using (dialog)
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Data.Uri = dialog.FileName;
                    }
                }
            }
        }
    }
}
