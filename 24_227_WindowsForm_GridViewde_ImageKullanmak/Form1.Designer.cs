namespace _24_227_WindowsForm_GridViewde_ImageKullanmak
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
            this.components = new System.ComponentModel.Container();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunResimYoluDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AllowUserToAddRows = false;
            this.dgwUrunler.AllowUserToDeleteRows = false;
            this.dgwUrunler.AutoGenerateColumns = false;
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunTanimDataGridViewTextBoxColumn,
            this.resimYolDataGridViewTextBoxColumn,
            this.urunResimYoluDataGridViewImageColumn});
            this.dgwUrunler.DataSource = this.urunBindingSource;
            this.dgwUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.Size = new System.Drawing.Size(561, 314);
            this.dgwUrunler.TabIndex = 0;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataSource = typeof(_24_227_WindowsForm_GridViewde_ImageKullanmak.Urun);
            // 
            // urunTanimDataGridViewTextBoxColumn
            // 
            this.urunTanimDataGridViewTextBoxColumn.DataPropertyName = "UrunTanim";
            this.urunTanimDataGridViewTextBoxColumn.HeaderText = "Ürün Tanım";
            this.urunTanimDataGridViewTextBoxColumn.Name = "urunTanimDataGridViewTextBoxColumn";
            this.urunTanimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunTanimDataGridViewTextBoxColumn.Width = 87;
            // 
            // resimYolDataGridViewTextBoxColumn
            // 
            this.resimYolDataGridViewTextBoxColumn.DataPropertyName = "ResimYol";
            this.resimYolDataGridViewTextBoxColumn.HeaderText = "Ürün Resmi";
            this.resimYolDataGridViewTextBoxColumn.Name = "resimYolDataGridViewTextBoxColumn";
            this.resimYolDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimYolDataGridViewTextBoxColumn.Width = 87;
            // 
            // urunResimYoluDataGridViewImageColumn
            // 
            this.urunResimYoluDataGridViewImageColumn.DataPropertyName = "UrunResimYolu";
            this.urunResimYoluDataGridViewImageColumn.HeaderText = "ÜrünResimYolu";
            this.urunResimYoluDataGridViewImageColumn.Name = "urunResimYoluDataGridViewImageColumn";
            this.urunResimYoluDataGridViewImageColumn.ReadOnly = true;
            this.urunResimYoluDataGridViewImageColumn.Width = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 314);
            this.Controls.Add(this.dgwUrunler);
            this.Name = "Form1";
            this.Text = "DataGridView - Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn urunResimYoluDataGridViewImageColumn;
    }
}

