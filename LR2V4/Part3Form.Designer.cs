using System;

namespace LR2V4
{
    partial class Part3Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part3Form));
            this.labelBack = new System.Windows.Forms.Label();
            this.btStartServer = new System.Windows.Forms.Button();
            this.btStartClient = new System.Windows.Forms.Button();
            this.btOpenCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btStartServer
            // 
            this.btStartServer.Location = new System.Drawing.Point(40, 65);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(368, 88);
            this.btStartServer.TabIndex = 12;
            this.btStartServer.Text = "Запустить сервер чата";
            this.btStartServer.UseVisualStyleBackColor = true;
            this.btStartServer.Click += new System.EventHandler(this.BtStartServer_Click);
            // 
            // btStartClient
            // 
            this.btStartClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartClient.Location = new System.Drawing.Point(437, 65);
            this.btStartClient.Name = "btStartClient";
            this.btStartClient.Size = new System.Drawing.Size(368, 88);
            this.btStartClient.TabIndex = 13;
            this.btStartClient.Text = "Запустить клиент чата";
            this.btStartClient.UseVisualStyleBackColor = true;
            this.btStartClient.Click += new System.EventHandler(this.BtStartClient_Click);
            // 
            // btOpenCatalog
            // 
            this.btOpenCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenCatalog.Location = new System.Drawing.Point(40, 201);
            this.btOpenCatalog.Name = "btOpenCatalog";
            this.btOpenCatalog.Size = new System.Drawing.Size(765, 107);
            this.btOpenCatalog.TabIndex = 14;
            this.btOpenCatalog.Text = "Открыть папку с скомпилированными приложениями";
            this.btOpenCatalog.UseVisualStyleBackColor = true;
            this.btOpenCatalog.Click += new System.EventHandler(this.BtOpenCatalog_Click);
            // 
            // Part3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 344);
            this.Controls.Add(this.btOpenCatalog);
            this.Controls.Add(this.btStartClient);
            this.Controls.Add(this.btStartServer);
            this.Controls.Add(this.labelBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Part3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 – часть 3. Работа с сокетами TCP в .NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Button btStartServer;
        private System.Windows.Forms.Button btStartClient;
        private System.Windows.Forms.Button btOpenCatalog;
    }
}