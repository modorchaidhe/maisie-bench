using System;
using System.Windows.Forms;

namespace CaraBosca.GUI
{
    public partial class UpdateNotifyDialog : Form
    {
        public UpdateNotifyDialog(string version, string title)
        {
            InitializeComponent();
            Text += " " + version;
            label1.Text += " " + title;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
