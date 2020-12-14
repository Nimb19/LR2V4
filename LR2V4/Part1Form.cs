using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LR2V4
{
    public partial class Part1Form : Form
    {
        public Part1Form()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void BtExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var address = tbAddress.Text.Trim();
                var ipAddresses = Dns.GetHostAddresses(address);
                tbResult.Text = $"Результат для \"{address}\":\r\n{string.Join(";\r\n", ipAddresses.Select(x => x.ToString()))}";
            }
            catch (Exception ex)
            {
                tbResult.Text = ex.Message;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtExecute_Click(sender, e);
        }

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
