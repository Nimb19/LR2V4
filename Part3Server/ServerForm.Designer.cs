using System;

namespace Part3Server
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.tbLogger = new System.Windows.Forms.TextBox();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenPort = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbLogger
            // 
            this.tbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogger.Location = new System.Drawing.Point(20, 129);
            this.tbLogger.Multiline = true;
            this.tbLogger.Name = "tbLogger";
            this.tbLogger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogger.Size = new System.Drawing.Size(486, 424);
            this.tbLogger.TabIndex = 10;
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(20, 67);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(344, 26);
            this.tbLocalPort.TabIndex = 5;
            this.tbLocalPort.Text = "12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Локальный порт:";
            // 
            // btOpenPort
            // 
            this.btOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenPort.Location = new System.Drawing.Point(424, 43);
            this.btOpenPort.Name = "btOpenPort";
            this.btOpenPort.Size = new System.Drawing.Size(376, 50);
            this.btOpenPort.TabIndex = 6;
            this.btOpenPort.Text = "Открыть порт";
            this.btOpenPort.UseVisualStyleBackColor = true;
            this.btOpenPort.Click += new System.EventHandler(this.BtOpenPort_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 20;
            this.listBoxUsers.Location = new System.Drawing.Point(526, 129);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(274, 424);
            this.listBoxUsers.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 572);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.tbLogger);
            this.Controls.Add(this.tbLocalPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 – часть 3. Работа с сокетами TCP в .NET. Форма сервера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLogger;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenPort;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Timer timer;
    }
}

