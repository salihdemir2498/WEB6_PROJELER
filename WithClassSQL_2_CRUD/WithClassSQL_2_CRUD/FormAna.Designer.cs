
namespace WithClassSQL_2_CRUD
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnBolum = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnHastalar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastalar.ForeColor = System.Drawing.Color.Crimson;
            this.btnHastalar.Location = new System.Drawing.Point(210, 50);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(208, 92);
            this.btnHastalar.TabIndex = 2;
            this.btnHastalar.Text = "Hastalar";
            this.btnHastalar.UseVisualStyleBackColor = false;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // btnBolum
            // 
            this.btnBolum.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBolum.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolum.ForeColor = System.Drawing.Color.Crimson;
            this.btnBolum.Location = new System.Drawing.Point(210, 166);
            this.btnBolum.Name = "btnBolum";
            this.btnBolum.Size = new System.Drawing.Size(208, 92);
            this.btnBolum.TabIndex = 3;
            this.btnBolum.Text = "BÖLÜMLER";
            this.btnBolum.UseVisualStyleBackColor = false;
            this.btnBolum.Click += new System.EventHandler(this.btnBolum_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRandevu.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.ForeColor = System.Drawing.Color.Crimson;
            this.btnRandevu.Location = new System.Drawing.Point(210, 281);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(208, 92);
            this.btnRandevu.TabIndex = 4;
            this.btnRandevu.Text = "RANDEVU";
            this.btnRandevu.UseVisualStyleBackColor = false;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(657, 437);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.btnBolum);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnBolum;
        private System.Windows.Forms.Button btnRandevu;
    }
}

