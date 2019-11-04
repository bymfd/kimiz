namespace kimiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGecmisSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwMasalar = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUrunler,
            this.btnGecmisSiparisler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnUrunler
            // 
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(58, 20);
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnGecmisSiparisler
            // 
            this.btnGecmisSiparisler.Name = "btnGecmisSiparisler";
            this.btnGecmisSiparisler.Size = new System.Drawing.Size(108, 20);
            this.btnGecmisSiparisler.Text = "Geçmiş Siparişler";
            this.btnGecmisSiparisler.Click += new System.EventHandler(this.btnGecmisSiparisler_Click);
            // 
            // lvwMasalar
            // 
            this.lvwMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMasalar.HideSelection = false;
            this.lvwMasalar.Location = new System.Drawing.Point(0, 24);
            this.lvwMasalar.Name = "lvwMasalar";
            this.lvwMasalar.Size = new System.Drawing.Size(554, 437);
            this.lvwMasalar.TabIndex = 1;
            this.lvwMasalar.UseCompatibleStateImageBehavior = false;
            this.lvwMasalar.DoubleClick += new System.EventHandler(this.lvwMasalar_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 461);
            this.Controls.Add(this.lvwMasalar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MFD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnUrunler;
        private System.Windows.Forms.ToolStripMenuItem btnGecmisSiparisler;
        private System.Windows.Forms.ListView lvwMasalar;
    }
}

