namespace RickStock_WindowsFormApp
{
    partial class ProductForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_barkodno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_urunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.checkBox_aktif = new System.Windows.Forms.CheckBox();
            this.cb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(460, 260);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(223, 35);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barkod No :";
            // 
            // tb_barkodno
            // 
            this.tb_barkodno.Location = new System.Drawing.Point(127, 31);
            this.tb_barkodno.Name = "tb_barkodno";
            this.tb_barkodno.Size = new System.Drawing.Size(224, 20);
            this.tb_barkodno.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün Adı : ";
            // 
            // tb_urunAdi
            // 
            this.tb_urunAdi.Location = new System.Drawing.Point(127, 64);
            this.tb_urunAdi.Name = "tb_urunAdi";
            this.tb_urunAdi.Size = new System.Drawing.Size(224, 20);
            this.tb_urunAdi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resim : ";
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(460, 114);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(224, 105);
            this.tb_aciklama.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(456, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fiyat : ";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(127, 97);
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(224, 20);
            this.nud_fiyat.TabIndex = 20;
            // 
            // checkBox_aktif
            // 
            this.checkBox_aktif.AutoSize = true;
            this.checkBox_aktif.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aktif.Location = new System.Drawing.Point(460, 229);
            this.checkBox_aktif.Name = "checkBox_aktif";
            this.checkBox_aktif.Size = new System.Drawing.Size(61, 24);
            this.checkBox_aktif.TabIndex = 21;
            this.checkBox_aktif.Text = "Aktif";
            this.checkBox_aktif.UseVisualStyleBackColor = true;
            // 
            // cb_kategoriler
            // 
            this.cb_kategoriler.FormattingEnabled = true;
            this.cb_kategoriler.Location = new System.Drawing.Point(460, 53);
            this.cb_kategoriler.Name = "cb_kategoriler";
            this.cb_kategoriler.Size = new System.Drawing.Size(223, 21);
            this.cb_kategoriler.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(456, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kategori";
            // 
            // pb_resim
            // 
            this.pb_resim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_resim.Image = global::RickStock_WindowsFormApp.Properties.Resources.add_image;
            this.pb_resim.Location = new System.Drawing.Point(127, 142);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(224, 152);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resim.TabIndex = 18;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_kategoriler);
            this.Controls.Add(this.checkBox_aktif);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_aciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_urunAdi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_barkodno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_barkodno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_urunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.CheckBox checkBox_aktif;
        private System.Windows.Forms.ComboBox cb_kategoriler;
        private System.Windows.Forms.Label label6;
    }
}