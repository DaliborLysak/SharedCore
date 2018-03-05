using System.Windows.Forms;

namespace CoreDialogs.Dialogs
{
    internal class ShowSaveDialog : DialogShowing
    {
        public override void ProcessFileDialog()
        {
            //base.ProcessFileDialog();

            ProcessFileDialog<SaveFileDialog>();
        }
    }
}
