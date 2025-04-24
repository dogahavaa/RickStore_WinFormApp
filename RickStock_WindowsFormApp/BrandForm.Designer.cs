namespace RickStock_WindowsFormApp
{
    partial class BrandForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox_aktif = new System.Windows.Forms.CheckBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.CMS_SilDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.CMS_SilDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // checkBox_aktif
            // 
            this.checkBox_aktif.AutoSize = true;
            this.checkBox_aktif.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aktif.Location = new System.Drawing.Point(12, 95);
            this.checkBox_aktif.Name = "checkBox_aktif";
            this.checkBox_aktif.Size = new System.Drawing.Size(61, 24);
            this.checkBox_aktif.TabIndex = 25;
            this.checkBox_aktif.Text = "Aktif";
            this.checkBox_aktif.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(12, 128);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(223, 35);
            this.btn_ekle.TabIndex = 24;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "İsim";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(12, 60);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(224, 20);
            this.tb_isim.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(304, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Logo";
            // 
            // pb_resim
            // 
            this.pb_resim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_resim.Image = global::RickStock_WindowsFormApp.Properties.Resources.add_image;
            this.pb_resim.Location = new System.Drawing.Point(371, 12);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(224, 151);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resim.TabIndex = 27;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // CMS_SilDuzenle
            // 
            this.CMS_SilDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Duzenle,
            this.TSMI_Sil});
            this.CMS_SilDuzenle.Name = "CMS_SilDuzenle";
            this.CMS_SilDuzenle.Size = new System.Drawing.Size(181, 70);
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
            // btn_duzenle
            // 
            this.btn_duzenle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_duzenle.Location = new System.Drawing.Point(13, 128);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(223, 35);
            this.btn_duzenle.TabIndex = 29;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_aktif);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.CMS_SilDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_aktif;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.ContextMenuStrip CMS_SilDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.Button btn_duzenle;
    }
}