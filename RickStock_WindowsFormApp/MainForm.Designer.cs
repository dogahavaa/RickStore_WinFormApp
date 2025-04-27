namespace RickStock_WindowsFormApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.bayilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Urunler,
            this.TSMI_MarkaIslemleri,
            this.TSMI_KategoriIslemleri,
            this.bayilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Urunler
            // 
            this.TSMI_Urunler.Name = "TSMI_Urunler";
            this.TSMI_Urunler.Size = new System.Drawing.Size(92, 20);
            this.TSMI_Urunler.Text = "Ürün İşlemleri";
            this.TSMI_Urunler.Click += new System.EventHandler(this.TSMI_Urunler_Click);
            // 
            // TSMI_MarkaIslemleri
            // 
            this.TSMI_MarkaIslemleri.Name = "TSMI_MarkaIslemleri";
            this.TSMI_MarkaIslemleri.Size = new System.Drawing.Size(99, 20);
            this.TSMI_MarkaIslemleri.Text = "Marka İşlemleri";
            this.TSMI_MarkaIslemleri.Click += new System.EventHandler(this.TSMI_MarkaIslemleri_Click);
            // 
            // TSMI_KategoriIslemleri
            // 
            this.TSMI_KategoriIslemleri.Name = "TSMI_KategoriIslemleri";
            this.TSMI_KategoriIslemleri.Size = new System.Drawing.Size(110, 20);
            this.TSMI_KategoriIslemleri.Text = "Kategori İşlemleri";
            this.TSMI_KategoriIslemleri.Click += new System.EventHandler(this.TSMI_KategoriIslemleri_Click);
            // 
            // bayilerToolStripMenuItem
            // 
            this.bayilerToolStripMenuItem.Name = "bayilerToolStripMenuItem";
            this.bayilerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.bayilerToolStripMenuItem.Text = "Bayiler";
            this.bayilerToolStripMenuItem.Click += new System.EventHandler(this.bayilerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urunler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem bayilerToolStripMenuItem;
    }
}