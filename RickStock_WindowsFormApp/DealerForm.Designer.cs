namespace RickStock_WindowsFormApp
{
    partial class DealerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_aktif = new System.Windows.Forms.CheckBox();
            this.btn_BayiEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_bayiTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_website = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bayiAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_bayilikTipiDuzenle = new System.Windows.Forms.Button();
            this.btn_BayilikTipiEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_indirimOrani = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bayilikTipi = new System.Windows.Forms.TextBox();
            this.dgv_bayiler = new System.Windows.Forms.DataGridView();
            this.dgv_bayilikTipleri = new System.Windows.Forms.DataGridView();
            this.CMS_SilDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bayiDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_indirimOrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bayiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bayilikTipleri)).BeginInit();
            this.CMS_SilDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_bayiDuzenle);
            this.groupBox1.Controls.Add(this.cbox_aktif);
            this.groupBox1.Controls.Add(this.btn_BayiEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_bayiTipi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_website);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_bayiAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bayi Oluştur";
            // 
            // cbox_aktif
            // 
            this.cbox_aktif.AutoSize = true;
            this.cbox_aktif.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_aktif.Location = new System.Drawing.Point(19, 202);
            this.cbox_aktif.Name = "cbox_aktif";
            this.cbox_aktif.Size = new System.Drawing.Size(96, 24);
            this.cbox_aktif.TabIndex = 35;
            this.cbox_aktif.Text = "Aktif Bayi";
            this.cbox_aktif.UseVisualStyleBackColor = true;
            // 
            // btn_BayiEkle
            // 
            this.btn_BayiEkle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_BayiEkle.Location = new System.Drawing.Point(18, 242);
            this.btn_BayiEkle.Name = "btn_BayiEkle";
            this.btn_BayiEkle.Size = new System.Drawing.Size(324, 35);
            this.btn_BayiEkle.TabIndex = 32;
            this.btn_BayiEkle.Text = "Bayi Ekle";
            this.btn_BayiEkle.UseVisualStyleBackColor = true;
            this.btn_BayiEkle.Click += new System.EventHandler(this.btn_BayiEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bayi Tipi";
            // 
            // cb_bayiTipi
            // 
            this.cb_bayiTipi.FormattingEnabled = true;
            this.cb_bayiTipi.Location = new System.Drawing.Point(19, 170);
            this.cb_bayiTipi.Name = "cb_bayiTipi";
            this.cb_bayiTipi.Size = new System.Drawing.Size(323, 21);
            this.cb_bayiTipi.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Website";
            // 
            // tb_website
            // 
            this.tb_website.Location = new System.Drawing.Point(19, 109);
            this.tb_website.Name = "tb_website";
            this.tb_website.Size = new System.Drawing.Size(324, 20);
            this.tb_website.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Bayi Adı";
            // 
            // tb_bayiAdi
            // 
            this.tb_bayiAdi.Location = new System.Drawing.Point(19, 50);
            this.tb_bayiAdi.Name = "tb_bayiAdi";
            this.tb_bayiAdi.Size = new System.Drawing.Size(324, 20);
            this.tb_bayiAdi.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_bayilikTipiDuzenle);
            this.groupBox2.Controls.Add(this.btn_BayilikTipiEkle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nud_indirimOrani);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_bayilikTipi);
            this.groupBox2.Location = new System.Drawing.Point(12, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bayilik Tipleri";
            // 
            // btn_bayilikTipiDuzenle
            // 
            this.btn_bayilikTipiDuzenle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_bayilikTipiDuzenle.Location = new System.Drawing.Point(18, 155);
            this.btn_bayilikTipiDuzenle.Name = "btn_bayilikTipiDuzenle";
            this.btn_bayilikTipiDuzenle.Size = new System.Drawing.Size(324, 35);
            this.btn_bayilikTipiDuzenle.TabIndex = 40;
            this.btn_bayilikTipiDuzenle.Text = "Düzenle";
            this.btn_bayilikTipiDuzenle.UseVisualStyleBackColor = true;
            this.btn_bayilikTipiDuzenle.Visible = false;
            this.btn_bayilikTipiDuzenle.Click += new System.EventHandler(this.btn_bayilikTipiDuzenle_Click);
            // 
            // btn_BayilikTipiEkle
            // 
            this.btn_BayilikTipiEkle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_BayilikTipiEkle.Location = new System.Drawing.Point(18, 155);
            this.btn_BayilikTipiEkle.Name = "btn_BayilikTipiEkle";
            this.btn_BayilikTipiEkle.Size = new System.Drawing.Size(324, 35);
            this.btn_BayilikTipiEkle.TabIndex = 36;
            this.btn_BayilikTipiEkle.Text = "Bayilik Tipi Ekle";
            this.btn_BayilikTipiEkle.UseVisualStyleBackColor = true;
            this.btn_BayilikTipiEkle.Click += new System.EventHandler(this.btn_BayilikTipiEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "İndirim Oranı";
            // 
            // nud_indirimOrani
            // 
            this.nud_indirimOrani.Location = new System.Drawing.Point(21, 113);
            this.nud_indirimOrani.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nud_indirimOrani.Name = "nud_indirimOrani";
            this.nud_indirimOrani.Size = new System.Drawing.Size(321, 20);
            this.nud_indirimOrani.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Bayilik Tipi";
            // 
            // tb_bayilikTipi
            // 
            this.tb_bayilikTipi.Location = new System.Drawing.Point(21, 53);
            this.tb_bayilikTipi.Name = "tb_bayilikTipi";
            this.tb_bayilikTipi.Size = new System.Drawing.Size(324, 20);
            this.tb_bayilikTipi.TabIndex = 36;
            // 
            // dgv_bayiler
            // 
            this.dgv_bayiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bayiler.Location = new System.Drawing.Point(409, 12);
            this.dgv_bayiler.Name = "dgv_bayiler";
            this.dgv_bayiler.Size = new System.Drawing.Size(503, 302);
            this.dgv_bayiler.TabIndex = 2;
            this.dgv_bayiler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_bayiler_MouseDown);
            // 
            // dgv_bayilikTipleri
            // 
            this.dgv_bayilikTipleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bayilikTipleri.Location = new System.Drawing.Point(409, 352);
            this.dgv_bayilikTipleri.Name = "dgv_bayilikTipleri";
            this.dgv_bayilikTipleri.Size = new System.Drawing.Size(341, 196);
            this.dgv_bayilikTipleri.TabIndex = 3;
            this.dgv_bayilikTipleri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_bayilikTipleri_MouseDown);
            // 
            // CMS_SilDuzenle
            // 
            this.CMS_SilDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Duzenle,
            this.TSMI_Sil});
            this.CMS_SilDuzenle.Name = "CMS_SilDuzenle";
            this.CMS_SilDuzenle.Size = new System.Drawing.Size(117, 48);
            // 
            // TSMI_Duzenle
            // 
            this.TSMI_Duzenle.Name = "TSMI_Duzenle";
            this.TSMI_Duzenle.Size = new System.Drawing.Size(116, 22);
            this.TSMI_Duzenle.Text = "Düzenle";
            this.TSMI_Duzenle.Click += new System.EventHandler(this.TSMI_Duzenle_Click);
            // 
            // TSMI_Sil
            // 
            this.TSMI_Sil.Name = "TSMI_Sil";
            this.TSMI_Sil.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Sil.Text = "Sil";
            this.TSMI_Sil.Click += new System.EventHandler(this.TSMI_Sil_Click);
            // 
            // btn_bayiDuzenle
            // 
            this.btn_bayiDuzenle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_bayiDuzenle.Location = new System.Drawing.Point(19, 242);
            this.btn_bayiDuzenle.Name = "btn_bayiDuzenle";
            this.btn_bayiDuzenle.Size = new System.Drawing.Size(324, 35);
            this.btn_bayiDuzenle.TabIndex = 41;
            this.btn_bayiDuzenle.Text = "Düzenle";
            this.btn_bayiDuzenle.UseVisualStyleBackColor = true;
            this.btn_bayiDuzenle.Visible = false;
            this.btn_bayiDuzenle.Click += new System.EventHandler(this.btn_bayiDuzenle_Click);
            // 
            // DealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 560);
            this.Controls.Add(this.dgv_bayilikTipleri);
            this.Controls.Add(this.dgv_bayiler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DealerForm";
            this.Text = "DealerForm";
            this.Load += new System.EventHandler(this.DealerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_indirimOrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bayiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bayilikTipleri)).EndInit();
            this.CMS_SilDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_bayiAdi;
        private System.Windows.Forms.Button btn_BayiEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_bayiTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_website;
        private System.Windows.Forms.CheckBox cbox_aktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bayilikTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_indirimOrani;
        private System.Windows.Forms.Button btn_BayilikTipiEkle;
        private System.Windows.Forms.DataGridView dgv_bayiler;
        private System.Windows.Forms.DataGridView dgv_bayilikTipleri;
        private System.Windows.Forms.Button btn_bayilikTipiDuzenle;
        private System.Windows.Forms.ContextMenuStrip CMS_SilDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.Button btn_bayiDuzenle;
    }
}