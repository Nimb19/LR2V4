namespace LR2V4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.part1Label = new System.Windows.Forms.Label();
            this.part2Label = new System.Windows.Forms.Label();
            this.part3Label = new System.Windows.Forms.Label();
            this.part4Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // part1Label
            // 
            this.part1Label.BackColor = System.Drawing.Color.Transparent;
            this.part1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part1Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.part1Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.part1Label.Location = new System.Drawing.Point(1, 221);
            this.part1Label.Name = "part1Label";
            this.part1Label.Size = new System.Drawing.Size(576, 74);
            this.part1Label.TabIndex = 0;
            this.part1Label.Text = "Часть 1. Работа с DNS в .NET";
            this.part1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.part1Label.Click += new System.EventHandler(this.Part1Label_Click);
            this.part1Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseDown);
            this.part1Label.MouseEnter += new System.EventHandler(this.PartLabel_MouseEnter);
            this.part1Label.MouseLeave += new System.EventHandler(this.PartLabel_MouseLeave);
            this.part1Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseUp);
            // 
            // part2Label
            // 
            this.part2Label.BackColor = System.Drawing.Color.Transparent;
            this.part2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part2Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.part2Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.part2Label.Location = new System.Drawing.Point(1, 319);
            this.part2Label.Name = "part2Label";
            this.part2Label.Size = new System.Drawing.Size(576, 74);
            this.part2Label.TabIndex = 1;
            this.part2Label.Text = "Часть 2. Работа с сокетами UDP в .NET";
            this.part2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.part2Label.Click += new System.EventHandler(this.Part2Label_Click);
            this.part2Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseDown);
            this.part2Label.MouseEnter += new System.EventHandler(this.PartLabel_MouseEnter);
            this.part2Label.MouseLeave += new System.EventHandler(this.PartLabel_MouseLeave);
            this.part2Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseUp);
            // 
            // part3Label
            // 
            this.part3Label.BackColor = System.Drawing.Color.Transparent;
            this.part3Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part3Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.part3Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.part3Label.Location = new System.Drawing.Point(1, 417);
            this.part3Label.Name = "part3Label";
            this.part3Label.Size = new System.Drawing.Size(576, 74);
            this.part3Label.TabIndex = 2;
            this.part3Label.Text = "Часть 3. Работа с сокетами TCP в .NET";
            this.part3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.part3Label.Click += new System.EventHandler(this.Part3Label_Click);
            this.part3Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseDown);
            this.part3Label.MouseEnter += new System.EventHandler(this.PartLabel_MouseEnter);
            this.part3Label.MouseLeave += new System.EventHandler(this.PartLabel_MouseLeave);
            this.part3Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseUp);
            // 
            // part4Label
            // 
            this.part4Label.BackColor = System.Drawing.Color.Transparent;
            this.part4Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part4Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.part4Label.ForeColor = System.Drawing.Color.Gainsboro;
            this.part4Label.Location = new System.Drawing.Point(1, 515);
            this.part4Label.Name = "part4Label";
            this.part4Label.Size = new System.Drawing.Size(576, 118);
            this.part4Label.TabIndex = 3;
            this.part4Label.Text = "Часть 4. Клиент-серверное приложение обмена шифрованными сообщениями между нескол" +
    "ькими клиентами (через сервер)";
            this.part4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.part4Label.Click += new System.EventHandler(this.Part4Label_Click);
            this.part4Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseDown);
            this.part4Label.MouseEnter += new System.EventHandler(this.PartLabel_MouseEnter);
            this.part4Label.MouseLeave += new System.EventHandler(this.PartLabel_MouseLeave);
            this.part4Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PartLabel_MouseUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(576, 69);
            this.label5.TabIndex = 4;
            this.label5.Text = "Лабораторная работа №2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(571, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "Событийно-управляемое, параллельное и распределенное программирование.\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Подготовил студент группы 3а-ИСиТ(о) Ганзин Юрий Михаилович";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LR2V4.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(577, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.part4Label);
            this.Controls.Add(this.part3Label);
            this.Controls.Add(this.part2Label);
            this.Controls.Add(this.part1Label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2. Выбор части";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label part1Label;
        private System.Windows.Forms.Label part2Label;
        private System.Windows.Forms.Label part3Label;
        private System.Windows.Forms.Label part4Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

