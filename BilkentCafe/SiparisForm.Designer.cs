namespace BilkentCafe
{
    partial class SiparisForm
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
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.nudUrunAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(12, 55);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(392, 323);
            this.dgvSiparisDetaylar.TabIndex = 0;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(8, 8);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(47, 17);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün :";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(214, 8);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(37, 17);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet";
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(316, 28);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(87, 23);
            this.btnSiparisDetayEkle.TabIndex = 3;
            this.btnSiparisDetayEkle.Text = "Ekle";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = true;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasaNo.Location = new System.Drawing.Point(431, 55);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(273, 145);
            this.lblMasaNo.TabIndex = 4;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(431, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ödeme Tutarı :";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Location = new System.Drawing.Point(532, 217);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(111, 23);
            this.lblOdemeTutari.TabIndex = 6;
            this.lblOdemeTutari.Text = "0,00 ₺";
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIptalEt.Location = new System.Drawing.Point(434, 243);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(129, 60);
            this.btnIptalEt.TabIndex = 7;
            this.btnIptalEt.Text = "Tüm Siparişleri İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdemeAl.Location = new System.Drawing.Point(571, 243);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(133, 60);
            this.btnOdemeAl.TabIndex = 8;
            this.btnOdemeAl.Text = "Ödeme alındı Hesabı Kapat";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAnasayfa.Location = new System.Drawing.Point(434, 314);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(269, 64);
            this.btnAnasayfa.TabIndex = 9;
            this.btnAnasayfa.Text = "<= Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // cboUrunler
            // 
            this.cboUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrunler.FormattingEnabled = true;
            this.cboUrunler.Location = new System.Drawing.Point(12, 28);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(198, 21);
            this.cboUrunler.TabIndex = 10;
            // 
            // nudUrunAdet
            // 
            this.nudUrunAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUrunAdet.Location = new System.Drawing.Point(217, 28);
            this.nudUrunAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUrunAdet.Name = "nudUrunAdet";
            this.nudUrunAdet.Size = new System.Drawing.Size(92, 20);
            this.nudUrunAdet.TabIndex = 11;
            this.nudUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 394);
            this.Controls.Add(this.nudUrunAdet);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnSiparisDetayEkle);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.NumericUpDown nudUrunAdet;
    }
}