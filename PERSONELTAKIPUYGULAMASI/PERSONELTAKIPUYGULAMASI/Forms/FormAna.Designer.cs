
namespace PERSONELTAKIPUYGULAMASI
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
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.cmbUnvanID = new System.Windows.Forms.ComboBox();
            this.cmbDepartmanID = new System.Windows.Forms.ComboBox();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbBaslar = new System.Windows.Forms.RadioButton();
            this.rdbBenzer = new System.Windows.Forms.RadioButton();
            this.rdbEslesen = new System.Windows.Forms.RadioButton();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.pnlAraclar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAraclar.Controls.Add(this.cmbDurumu);
            this.pnlAraclar.Controls.Add(this.cmbUnvanID);
            this.pnlAraclar.Controls.Add(this.cmbDepartmanID);
            this.pnlAraclar.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.dtpDogumTarihi);
            this.pnlAraclar.Controls.Add(this.txtPersonelNo);
            this.pnlAraclar.Controls.Add(this.txtTcNo);
            this.pnlAraclar.Controls.Add(this.txtSoyad);
            this.pnlAraclar.Controls.Add(this.txtAd);
            this.pnlAraclar.Controls.Add(this.label9);
            this.pnlAraclar.Controls.Add(this.label8);
            this.pnlAraclar.Controls.Add(this.label7);
            this.pnlAraclar.Controls.Add(this.label6);
            this.pnlAraclar.Controls.Add(this.label5);
            this.pnlAraclar.Controls.Add(this.label4);
            this.pnlAraclar.Controls.Add(this.label3);
            this.pnlAraclar.Controls.Add(this.label2);
            this.pnlAraclar.Controls.Add(this.label1);
            this.pnlAraclar.Location = new System.Drawing.Point(12, 12);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(485, 327);
            this.pnlAraclar.TabIndex = 0;
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDurumu.Location = new System.Drawing.Point(211, 277);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(243, 24);
            this.cmbDurumu.TabIndex = 16;
            this.cmbDurumu.Tag = "Durumu";
            // 
            // cmbUnvanID
            // 
            this.cmbUnvanID.FormattingEnabled = true;
            this.cmbUnvanID.Items.AddRange(new object[] {
            "İşçi",
            "Ekip Lideri",
            "Yönetici Yardımcısı",
            "Yönetici"});
            this.cmbUnvanID.Location = new System.Drawing.Point(211, 241);
            this.cmbUnvanID.Name = "cmbUnvanID";
            this.cmbUnvanID.Size = new System.Drawing.Size(243, 24);
            this.cmbUnvanID.TabIndex = 15;
            this.cmbUnvanID.Tag = "UnvanID";
            // 
            // cmbDepartmanID
            // 
            this.cmbDepartmanID.FormattingEnabled = true;
            this.cmbDepartmanID.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Muhasebe",
            "Satış",
            "Üretim",
            "Teknik"});
            this.cmbDepartmanID.Location = new System.Drawing.Point(211, 204);
            this.cmbDepartmanID.Name = "cmbDepartmanID";
            this.cmbDepartmanID.Size = new System.Drawing.Size(243, 24);
            this.cmbDepartmanID.TabIndex = 14;
            this.cmbDepartmanID.Tag = "DepartmanID";
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(214, 172);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(240, 22);
            this.dtpIseBaslamaTarihi.TabIndex = 13;
            this.dtpIseBaslamaTarihi.Tag = "IseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(214, 143);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(240, 22);
            this.dtpDogumTarihi.TabIndex = 12;
            this.dtpDogumTarihi.Tag = "DogumTarihi";
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(214, 114);
            this.txtPersonelNo.MaxLength = 5;
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(240, 22);
            this.txtPersonelNo.TabIndex = 11;
            this.txtPersonelNo.Tag = "PersonelNo";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(214, 86);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(240, 22);
            this.txtTcNo.TabIndex = 10;
            this.txtTcNo.Tag = "TcNo";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(214, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(240, 22);
            this.txtSoyad.TabIndex = 9;
            this.txtSoyad.Tag = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(214, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(240, 22);
            this.txtAd.TabIndex = 8;
            this.txtAd.Tag = "Ad";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Desktop;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "DURUMU";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "ÜNVAN";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "DepartmanID";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "İŞE BAŞLAMA TARİHİ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "DOĞUM TARİHİ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "PERSONEL NO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC KİMLİK NO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbBaslar);
            this.panel2.Controls.Add(this.rdbBenzer);
            this.panel2.Controls.Add(this.rdbEslesen);
            this.panel2.Controls.Add(this.btnBul);
            this.panel2.Controls.Add(this.btnGetir);
            this.panel2.Controls.Add(this.btnHepsiniSil);
            this.panel2.Controls.Add(this.btnTemizle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Location = new System.Drawing.Point(12, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 239);
            this.panel2.TabIndex = 1;
            // 
            // rdbBaslar
            // 
            this.rdbBaslar.AutoSize = true;
            this.rdbBaslar.Location = new System.Drawing.Point(213, 191);
            this.rdbBaslar.Name = "rdbBaslar";
            this.rdbBaslar.Size = new System.Drawing.Size(69, 21);
            this.rdbBaslar.TabIndex = 9;
            this.rdbBaslar.Text = "Başlar";
            this.rdbBaslar.UseVisualStyleBackColor = true;
            // 
            // rdbBenzer
            // 
            this.rdbBenzer.AutoSize = true;
            this.rdbBenzer.Location = new System.Drawing.Point(288, 191);
            this.rdbBenzer.Name = "rdbBenzer";
            this.rdbBenzer.Size = new System.Drawing.Size(74, 21);
            this.rdbBenzer.TabIndex = 8;
            this.rdbBenzer.Text = "Benzer";
            this.rdbBenzer.UseVisualStyleBackColor = true;
            // 
            // rdbEslesen
            // 
            this.rdbEslesen.AutoSize = true;
            this.rdbEslesen.Checked = true;
            this.rdbEslesen.Location = new System.Drawing.Point(368, 191);
            this.rdbEslesen.Name = "rdbEslesen";
            this.rdbEslesen.Size = new System.Drawing.Size(114, 21);
            this.rdbEslesen.TabIndex = 8;
            this.rdbEslesen.TabStop = true;
            this.rdbEslesen.Text = "Tam Eşleşme";
            this.rdbEslesen.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBul.Location = new System.Drawing.Point(232, 139);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(219, 35);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetir.Location = new System.Drawing.Point(22, 139);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(204, 35);
            this.btnGetir.TabIndex = 5;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHepsiniSil.Location = new System.Drawing.Point(299, 82);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(152, 35);
            this.btnHepsiniSil.TabIndex = 4;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTemizle.Location = new System.Drawing.Point(144, 82);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(149, 35);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSil.Location = new System.Drawing.Point(22, 82);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(232, 27);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(219, 35);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnKaydet.Location = new System.Drawing.Point(22, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(204, 35);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.GridColor = System.Drawing.Color.Coral;
            this.dgvCalisanlar.Location = new System.Drawing.Point(503, 13);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.RowHeadersWidth = 51;
            this.dgvCalisanlar.RowTemplate.Height = 24;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(1045, 587);
            this.dgvCalisanlar.TabIndex = 2;
            this.dgvCalisanlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellEnter);
            this.dgvCalisanlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCalisanlar_KeyPress);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1560, 604);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAraclar);
            this.Name = "FormAna";
            this.Text = "WİSSEN AKADEMIE-PERSONEL TAKİP";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.ComboBox cmbUnvanID;
        private System.Windows.Forms.ComboBox cmbDepartmanID;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.RadioButton rdbBaslar;
        private System.Windows.Forms.RadioButton rdbBenzer;
        private System.Windows.Forms.RadioButton rdbEslesen;
    }
}

