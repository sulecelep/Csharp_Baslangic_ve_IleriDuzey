﻿namespace _24_201_WindowsForm_Show_ShowDialog
{
    partial class Form1
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGosterPopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(164, 102);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(112, 59);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGosterPopup
            // 
            this.btnGosterPopup.Location = new System.Drawing.Point(301, 102);
            this.btnGosterPopup.Name = "btnGosterPopup";
            this.btnGosterPopup.Size = new System.Drawing.Size(107, 59);
            this.btnGosterPopup.TabIndex = 1;
            this.btnGosterPopup.Text = "Göster Popup";
            this.btnGosterPopup.UseVisualStyleBackColor = true;
            this.btnGosterPopup.Click += new System.EventHandler(this.btnGosterPopup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 295);
            this.Controls.Add(this.btnGosterPopup);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGosterPopup;
    }
}

