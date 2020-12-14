using System;
using System.Windows.Forms;

namespace Part4Client
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tbLogger = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btDisconnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLogger
            // 
            this.tbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogger.Location = new System.Drawing.Point(20, 212);
            this.tbLogger.Multiline = true;
            this.tbLogger.Name = "tbLogger";
            this.tbLogger.ReadOnly = true;
            this.tbLogger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogger.Size = new System.Drawing.Size(920, 464);
            this.tbLogger.TabIndex = 10;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(20, 49);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(165, 26);
            this.tbHost.TabIndex = 5;
            this.tbHost.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Хост:";
            // 
            // btConnect
            // 
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnect.Location = new System.Drawing.Point(544, 26);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(195, 49);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Подключиться";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDisconnect.Location = new System.Drawing.Point(745, 26);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(195, 49);
            this.btDisconnect.TabIndex = 12;
            this.btDisconnect.Text = "Отключиться";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.BtDisconnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPort.Location = new System.Drawing.Point(191, 49);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(165, 26);
            this.tbPort.TabIndex = 13;
            this.tbPort.Text = "12345";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Порт:";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Location = new System.Drawing.Point(362, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 26);
            this.tbName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Имя:";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(20, 105);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(920, 61);
            this.tbMessage.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Сообщение:";
            // 
            // btSendMessage
            // 
            this.btSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendMessage.Location = new System.Drawing.Point(20, 172);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(920, 34);
            this.btSendMessage.TabIndex = 19;
            this.btSendMessage.Text = "Отправить";
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.BtSendMessage_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 688);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.tbLogger);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 – часть 4. Форма клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLogger;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSendMessage;
    }
}

