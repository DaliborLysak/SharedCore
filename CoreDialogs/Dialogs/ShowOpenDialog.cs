using System.Windows.Forms;

namespace CoreDialogs.Dialogs
{
    internal class ShowOpenDialog : DialogShowing
    {
        public override void ProcessFileDialog()
        {
            //base.ProcessFileDialog();

            ProcessFileDialog<OpenFileDialog>();
        }
    }
}
