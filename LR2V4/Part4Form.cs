using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LR2V4
{
    public partial class Part4Form : Form
    {
        public Part4Form()
        {
            InitializeComponent();
        }

        private void BtStartServer_Click(object sender, EventArgs e) =>
            Process.Start($@"{Directory.GetCurrentDirectory()}\Part4Server\Part4Server.exe");

        private void BtStartClient_Click(object sender, EventArgs e) =>
            Process.Start($@"{Directory.GetCurrentDirectory()}\Part4Client\Part4Client.exe");

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
