using System;

namespace LR2V4
{
    partial class Part2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part2Form));
            this.btOpenPort = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbLogger = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOpenPort
            // 
            this.btOpenPort.Location = new System.Drawing.Point(251, 65);
            this.btOpenPort.Name = "btOpenPort";
            this.btOpenPort.Size = new System.Drawing.Size(295, 37);
            this.btOpenPort.TabIndex = 1;
            this.btOpenPort.Text = "Открыть порт";
            this.btOpenPort.UseVisualStyleBackColor = true;
            this.btOpenPort.Click += new System.EventHandler(this.BtOpenPort_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(569, 12);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(191, 295);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Локальный порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Хост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Порт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сообщение:";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(12, 76);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(194, 26);
            this.tbLocalPort.TabIndex = 0;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(12, 149);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(194, 26);
            this.tbHost.TabIndex = 2;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 226);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(534, 81);
            this.tbMessage.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(251, 149);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(295, 26);
            this.tbPort.TabIndex = 3;
            // 
            // tbLogger
            // 
            this.tbLogger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogger.Location = new System.Drawing.Point(12, 322);
            this.tbLogger.Multiline = true;
            this.tbLogger.Name = "tbLogger";
            this.tbLogger.Size = new System.Drawing.Size(748, 199);
            this.tbLogger.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.Location = new System.Drawing.Point(9, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(202, 18);
            this.labelBack.TabIndex = 11;
            this.labelBack.Text = "❮ Вернуться в меню выбора";
            this.labelBack.Click += new System.EventHandler(this.LabelBack_Click);
            this.labelBack.MouseEnter += new System.EventHandler(this.LabelBack_MouseEnter);
            this.labelBack.MouseLeave += new System.EventHandler(this.LabelBack_MouseLeave);
            // 
            // Part2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 533);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.tbLogger);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.tbLocalPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btOpenPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Part2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 – часть 2. Работа с сокетами UDP в .NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpenPort;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbLogger;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelBack;
    }
}