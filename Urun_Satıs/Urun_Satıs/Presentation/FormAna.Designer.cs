
namespace Urun_Satıs
{
    partial class FormAna
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
            this.txtSatisAdedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunAd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSatisAdedi
            // 
            this.txtSatisAdedi.Location = new System.Drawing.Point(304, 114);
            this.txtSatisAdedi.Name = "txtSatisAdedi";
            this.txtSatisAdedi.Size = new System.Drawing.Size(200, 22);
            this.txtSatisAdedi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün AD:";
            // 
            // cmbUrunAd
            // 
            this.cmbUrunAd.FormattingEnabled = true;
            this.cmbUrunAd.Location = new System.Drawing.Point(304, 28);
            this.cmbUrunAd.Name = "cmbUrunAd";
            this.cmbUrunAd.Size = new System.Drawing.Size(200, 24);
            this.cmbUrunAd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Satış Adedi:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(304, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 34);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpSatisTarih
            // 
            this.dtpSatisTarih.Location = new System.Drawing.Point(304, 76);
            this.dtpSatisTarih.Name = "dtpSatisTarih";
            this.dtpSatisTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpSatisTarih.TabIndex = 7;
            this.dtpSatisTarih.ValueChanged += new System.EventHandler(this.dtpSatisTarih_ValueChanged);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpSatisTarih);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSatisAdedi);
            this.Controls.Add(this.cmbUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormAna";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatisAdedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpSatisTarih;
    }
}

