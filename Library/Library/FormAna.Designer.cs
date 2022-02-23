
namespace Library
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
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnYayinevleri = new System.Windows.Forms.Button();
            this.btnYazarlar = new System.Windows.Forms.Button();
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnTurler = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnKitaplar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitaplar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnKitaplar.Location = new System.Drawing.Point(278, 292);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(207, 61);
            this.btnKitaplar.TabIndex = 9;
            this.btnKitaplar.Text = "KİTAPLAR";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnYayinevleri
            // 
            this.btnYayinevleri.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYayinevleri.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinevleri.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnYayinevleri.Location = new System.Drawing.Point(278, 225);
            this.btnYayinevleri.Name = "btnYayinevleri";
            this.btnYayinevleri.Size = new System.Drawing.Size(207, 61);
            this.btnYayinevleri.TabIndex = 8;
            this.btnYayinevleri.Text = "YAYIN EVLERİ";
            this.btnYayinevleri.UseVisualStyleBackColor = false;
            this.btnYayinevleri.Click += new System.EventHandler(this.btnYayinevleri_Click);
            // 
            // btnYazarlar
            // 
            this.btnYazarlar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYazarlar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarlar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnYazarlar.Location = new System.Drawing.Point(278, 158);
            this.btnYazarlar.Name = "btnYazarlar";
            this.btnYazarlar.Size = new System.Drawing.Size(207, 61);
            this.btnYazarlar.TabIndex = 7;
            this.btnYazarlar.Text = "YAZARLAR";
            this.btnYazarlar.UseVisualStyleBackColor = false;
            this.btnYazarlar.Click += new System.EventHandler(this.btnYazarlar_Click);
            // 
            // btnUyeler
            // 
            this.btnUyeler.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUyeler.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeler.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnUyeler.Location = new System.Drawing.Point(278, 91);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(207, 61);
            this.btnUyeler.TabIndex = 6;
            this.btnUyeler.Text = "ÜYELER";
            this.btnUyeler.UseVisualStyleBackColor = false;
            this.btnUyeler.Click += new System.EventHandler(this.btnUyeler_Click);
            // 
            // btnTurler
            // 
            this.btnTurler.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTurler.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurler.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTurler.Location = new System.Drawing.Point(278, 24);
            this.btnTurler.Name = "btnTurler";
            this.btnTurler.Size = new System.Drawing.Size(207, 61);
            this.btnTurler.TabIndex = 5;
            this.btnTurler.Text = "TÜRLER";
            this.btnTurler.UseVisualStyleBackColor = false;
            this.btnTurler.Click += new System.EventHandler(this.btnTurler_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnKitaplar);
            this.Controls.Add(this.btnYayinevleri);
            this.Controls.Add(this.btnYazarlar);
            this.Controls.Add(this.btnUyeler);
            this.Controls.Add(this.btnTurler);
            this.Name = "FormAna";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnYayinevleri;
        private System.Windows.Forms.Button btnYazarlar;
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnTurler;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

