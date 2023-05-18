namespace _24_202_WindowsForm_FormControllere_Nasil_Ulasilir
{
    partial class frmOnizlemeKayit
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblIsimOnizleme = new System.Windows.Forms.Label();
            this.txtIsimOnizleme = new System.Windows.Forms.TextBox();
            this.lblEmailAdresOnizleme = new System.Windows.Forms.Label();
            this.lblSoyisimOnizleme = new System.Windows.Forms.Label();
            this.txtEmailAdresOnizleme = new System.Windows.Forms.TextBox();
            this.txtSoyisimOnizleme = new System.Windows.Forms.TextBox();
            this.lblTelefonOnizleme = new System.Windows.Forms.Label();
            this.txtTelefonOnizleme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(265, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 99);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblIsimOnizleme
            // 
            this.lblIsimOnizleme.AutoSize = true;
            this.lblIsimOnizleme.Location = new System.Drawing.Point(9, 15);
            this.lblIsimOnizleme.Name = "lblIsimOnizleme";
            this.lblIsimOnizleme.Size = new System.Drawing.Size(25, 13);
            this.lblIsimOnizleme.TabIndex = 12;
            this.lblIsimOnizleme.Text = "İsim";
            // 
            // txtIsimOnizleme
            // 
            this.txtIsimOnizleme.Enabled = false;
            this.txtIsimOnizleme.Location = new System.Drawing.Point(79, 12);
            this.txtIsimOnizleme.Name = "txtIsimOnizleme";
            this.txtIsimOnizleme.Size = new System.Drawing.Size(180, 20);
            this.txtIsimOnizleme.TabIndex = 7;
            // 
            // lblEmailAdresOnizleme
            // 
            this.lblEmailAdresOnizleme.AutoSize = true;
            this.lblEmailAdresOnizleme.Location = new System.Drawing.Point(9, 68);
            this.lblEmailAdresOnizleme.Name = "lblEmailAdresOnizleme";
            this.lblEmailAdresOnizleme.Size = new System.Drawing.Size(62, 13);
            this.lblEmailAdresOnizleme.TabIndex = 11;
            this.lblEmailAdresOnizleme.Text = "Email Adres";
            // 
            // lblSoyisimOnizleme
            // 
            this.lblSoyisimOnizleme.AutoSize = true;
            this.lblSoyisimOnizleme.Location = new System.Drawing.Point(9, 41);
            this.lblSoyisimOnizleme.Name = "lblSoyisimOnizleme";
            this.lblSoyisimOnizleme.Size = new System.Drawing.Size(42, 13);
            this.lblSoyisimOnizleme.TabIndex = 10;
            this.lblSoyisimOnizleme.Text = "Soyisim";
            // 
            // txtEmailAdresOnizleme
            // 
            this.txtEmailAdresOnizleme.Enabled = false;
            this.txtEmailAdresOnizleme.Location = new System.Drawing.Point(79, 65);
            this.txtEmailAdresOnizleme.Name = "txtEmailAdresOnizleme";
            this.txtEmailAdresOnizleme.Size = new System.Drawing.Size(180, 20);
            this.txtEmailAdresOnizleme.TabIndex = 13;
            // 
            // txtSoyisimOnizleme
            // 
            this.txtSoyisimOnizleme.Enabled = false;
            this.txtSoyisimOnizleme.Location = new System.Drawing.Point(79, 38);
            this.txtSoyisimOnizleme.Name = "txtSoyisimOnizleme";
            this.txtSoyisimOnizleme.Size = new System.Drawing.Size(180, 20);
            this.txtSoyisimOnizleme.TabIndex = 9;
            // 
            // lblTelefonOnizleme
            // 
            this.lblTelefonOnizleme.AutoSize = true;
            this.lblTelefonOnizleme.Location = new System.Drawing.Point(9, 94);
            this.lblTelefonOnizleme.Name = "lblTelefonOnizleme";
            this.lblTelefonOnizleme.Size = new System.Drawing.Size(43, 13);
            this.lblTelefonOnizleme.TabIndex = 8;
            this.lblTelefonOnizleme.Text = "Telefon";
            // 
            // txtTelefonOnizleme
            // 
            this.txtTelefonOnizleme.Enabled = false;
            this.txtTelefonOnizleme.Location = new System.Drawing.Point(79, 91);
            this.txtTelefonOnizleme.Name = "txtTelefonOnizleme";
            this.txtTelefonOnizleme.Size = new System.Drawing.Size(180, 20);
            this.txtTelefonOnizleme.TabIndex = 14;
            // 
            // frmOnizlemeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 142);
            this.Controls.Add(this.txtTelefonOnizleme);
            this.Controls.Add(this.lblTelefonOnizleme);
            this.Controls.Add(this.txtSoyisimOnizleme);
            this.Controls.Add(this.txtEmailAdresOnizleme);
            this.Controls.Add(this.lblSoyisimOnizleme);
            this.Controls.Add(this.lblEmailAdresOnizleme);
            this.Controls.Add(this.txtIsimOnizleme);
            this.Controls.Add(this.lblIsimOnizleme);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOnizlemeKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Önizleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblIsimOnizleme;
        private System.Windows.Forms.TextBox txtIsimOnizleme;
        private System.Windows.Forms.Label lblEmailAdresOnizleme;
        private System.Windows.Forms.Label lblSoyisimOnizleme;
        private System.Windows.Forms.TextBox txtEmailAdresOnizleme;
        private System.Windows.Forms.TextBox txtSoyisimOnizleme;
        private System.Windows.Forms.Label lblTelefonOnizleme;
        private System.Windows.Forms.TextBox txtTelefonOnizleme;
    }
}