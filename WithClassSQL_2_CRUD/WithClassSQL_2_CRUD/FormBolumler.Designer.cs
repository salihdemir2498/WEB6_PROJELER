
namespace WithClassSQL_2_CRUD
{
    partial class FormBolumler
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
            this.dgvBolumler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBolumler
            // 
            this.dgvBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolumler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBolumler.Location = new System.Drawing.Point(0, 0);
            this.dgvBolumler.Name = "dgvBolumler";
            this.dgvBolumler.RowHeadersWidth = 51;
            this.dgvBolumler.RowTemplate.Height = 24;
            this.dgvBolumler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBolumler.Size = new System.Drawing.Size(443, 213);
            this.dgvBolumler.TabIndex = 0;
            this.dgvBolumler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBolumler_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm Ad:";
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(15, 281);
            this.txtBolumAd.Multiline = true;
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(129, 27);
            this.txtBolumAd.TabIndex = 2;
            this.txtBolumAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBolumAd_KeyPress);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(181, 280);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(82, 28);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(281, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 28);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Yeni Bölüm Kaydı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBolumler);
            this.Name = "FormBolumler";
            this.Text = "FormBolumler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBolumler_FormClosing);
            this.Load += new System.EventHandler(this.FormBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolumler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
    }
}