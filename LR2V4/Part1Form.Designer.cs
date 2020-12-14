using System;
using System.Windows.Forms;

namespace LR2V4
{
    partial class Part1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part1Form));
            this.btExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.labelBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(432, 69);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(233, 50);
            this.btExecute.TabIndex = 0;
            this.btExecute.Text = "Выполнить";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.BtExecute_Click);
            this.btExecute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(28, 93);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(344, 26);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(28, 195);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(637, 208);
            this.tbResult.TabIndex = 4;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.Location = new System.Drawing.Point(12, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(202, 18);
            this.labelBack.TabIndex = 3;
            this.labelBack.Text = "❮ Вернуться в меню выбора";
            this.labelBack.Click += new System.EventHandler(this.LabelBack_Click);
            this.labelBack.MouseEnter += new System.EventHandler(this.LabelBack_MouseEnter);
            this.labelBack.MouseLeave += new System.EventHandler(this.LabelBack_MouseLeave);
            // 
            // Part1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 429);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExecute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Part1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 – часть 1. Работа с DNS в .NET";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbResult;
        private Label labelBack;
    }
}