using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR2V4
{
    public partial class MainForm : Form
    {
        public readonly Font DEFAULT_FONT = new Font("Century Gothic", 18, FontStyle.Bold);
        public readonly Font MOUSEDOWN_FONT = new Font("Century Gothic", 17, FontStyle.Bold);

        public readonly Color HOVER_COLOR = Color.White; // ColorTranslator.FromHtml("#EDD1E5")
        public readonly Color DEFAULT_COLOR = Color.Gainsboro;
        public readonly Color MOUSEDOWN_COLOR = Color.White; // ColorTranslator.FromHtml("#CABBED")

        public MainForm()
        {
            this.Hide();

            InitializeComponent();
            SetFormSettings();

            ShowThisForm();
        }

        private void Part1Label_Click(object sender, EventArgs e) => ShowPartForm(new Part1Form());
        private void Part2Label_Click(object sender, EventArgs e) => ShowPartForm(new Part2Form());
        private void Part3Label_Click(object sender, EventArgs e) => ShowPartForm(new Part3Form());
        private void Part4Label_Click(object sender, EventArgs e) => ShowPartForm(new Part4Form());

        private void ShowPartForm(Form form)
        {
            try
            {
                this.Hide();

                if (form.ShowDialog() != DialogResult.Yes)
                    this.Close();
                else
                    ShowThisForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowThisForm();
            }
        }

        private void SetFormSettings()
        {
            MaximizeBox = false; // MinimizeBox = false;
            timer.Tick += (sender, e) => { Opacity += 0.3; if (Opacity == 1) timer.Enabled = false; };

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.ContainerControl |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.DoubleBuffer
                , true);
        }

        #region Обработка декоративных методов/событий. Настройка цвета и шрифта надписей при наведении и т.д.
        private void ShowThisForm()
        {
            this.Opacity = 0;
            this.Show();

            timer.Enabled = true;
        }

        private void PartLabel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label)
                label.ForeColor = HOVER_COLOR;
        }

        private void PartLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
                label.ForeColor = DEFAULT_COLOR;
        }

        private void PartLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Label label)
            {
                label.Font = MOUSEDOWN_FONT;
                label.ForeColor = MOUSEDOWN_COLOR;
            }
        }

        private void PartLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Label label)
            {
                label.Font = DEFAULT_FONT;
                label.ForeColor = HOVER_COLOR;
            }
        }
        #endregion
    }
}
