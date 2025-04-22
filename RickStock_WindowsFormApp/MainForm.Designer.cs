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
            this.TSMI_Anasayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunleriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MarkaListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MarkaEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Anasayfa,
            this.TSMI_Urunler,
            this.TSMI_MarkaIslemleri,
            this.TSMI_KategoriIslemleri,
            this.TSMI_CikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Anasayfa
            // 
            this.TSMI_Anasayfa.Name = "TSMI_Anasayfa";
            this.TSMI_Anasayfa.Size = new System.Drawing.Size(67, 20);
            this.TSMI_Anasayfa.Text = "Anasayfa";
            // 
            // TSMI_Urunler
            // 
            this.TSMI_Urunler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UrunleriListele,
            this.TSMI_UrunEkle});
            this.TSMI_Urunler.Name = "TSMI_Urunler";
            this.TSMI_Urunler.Size = new System.Drawing.Size(92, 20);
            this.TSMI_Urunler.Text = "Ürün İşlemleri";
            // 
            // TSMI_UrunleriListele
            // 
            this.TSMI_UrunleriListele.Name = "TSMI_UrunleriListele";
            this.TSMI_UrunleriListele.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunleriListele.Text = "Ürünlerim";
            // 
            // TSMI_UrunEkle
            // 
            this.TSMI_UrunEkle.Name = "TSMI_UrunEkle";
            this.TSMI_UrunEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunEkle.Text = "Ürün Ekle";
            // 
            // TSMI_MarkaIslemleri
            // 
            this.TSMI_MarkaIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_MarkaListele,
            this.TSMI_MarkaEkle});
            this.TSMI_MarkaIslemleri.Name = "TSMI_MarkaIslemleri";
            this.TSMI_MarkaIslemleri.Size = new System.Drawing.Size(99, 20);
            this.TSMI_MarkaIslemleri.Text = "Marka İşlemleri";
            // 
            // TSMI_MarkaListele
            // 
            this.TSMI_MarkaListele.Name = "TSMI_MarkaListele";
            this.TSMI_MarkaListele.Size = new System.Drawing.Size(180, 22);
            this.TSMI_MarkaListele.Text = "Markalar";
            // 
            // TSMI_MarkaEkle
            // 
            this.TSMI_MarkaEkle.Name = "TSMI_MarkaEkle";
            this.TSMI_MarkaEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_MarkaEkle.Text = "Marka Ekle";
            // 
            // TSMI_KategoriIslemleri
            // 
            this.TSMI_KategoriIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kategoriler,
            this.TSMI_KategoriEkle});
            this.TSMI_KategoriIslemleri.Name = "TSMI_KategoriIslemleri";
            this.TSMI_KategoriIslemleri.Size = new System.Drawing.Size(110, 20);
            this.TSMI_KategoriIslemleri.Text = "Kategori İşlemleri";
            // 
            // TSMI_Kategoriler
            // 
            this.TSMI_Kategoriler.Name = "TSMI_Kategoriler";
            this.TSMI_Kategoriler.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kategoriler.Text = "Kategoriler";
            // 
            // TSMI_KategoriEkle
            // 
            this.TSMI_KategoriEkle.Name = "TSMI_KategoriEkle";
            this.TSMI_KategoriEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_KategoriEkle.Text = "Kategori Ekle";
            // 
            // TSMI_CikisYap
            // 
            this.TSMI_CikisYap.Name = "TSMI_CikisYap";
            this.TSMI_CikisYap.Size = new System.Drawing.Size(66, 20);
            this.TSMI_CikisYap.Text = "Çıkış Yap";
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Anasayfa;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Urunler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunleriListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MarkaListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MarkaEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kategoriler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CikisYap;
    }
}