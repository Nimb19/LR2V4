using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LR2V4
{
    public partial class Part3Form : Form
    {
        public Part3Form()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void BtStartServer_Click(object sender, EventArgs e) =>
            Process.Start($@"{Directory.GetCurrentDirectory()}\Part3Server\Part3Server.exe");

        private void BtStartClient_Click(object sender, EventArgs e) =>
            Process.Start($@"{Directory.GetCurrentDirectory()}\Part3Client\Part3Client.exe");

        private void BtOpenCatalog_Click(object sender, EventArgs e) =>
            Process.Start($@"{Directory.GetCurrentDirectory()}");

        #region Обработка событий LabelBack
        private void LabelBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline);
        }

        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular);
        }
        #endregion
    }
}
