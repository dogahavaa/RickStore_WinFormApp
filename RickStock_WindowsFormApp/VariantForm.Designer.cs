namespace RickStock_WindowsFormApp
{
    partial class VariantForm
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
            this.btn_xml = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_deger = new System.Windows.Forms.TextBox();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_varyasyonTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xml
            // 
            this.btn_xml.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xml.Location = new System.Drawing.Point(25, 174);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(266, 35);
            this.btn_xml.TabIndex = 31;
            this.btn_xml.Text = "Varyans Ekle";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Varyasyon Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Değer";
            // 
            // tb_deger
            // 
            this.tb_deger.Location = new System.Drawing.Point(25, 86);
            this.tb_deger.Name = "tb_deger";
            this.tb_deger.Size = new System.Drawing.Size(266, 20);
            this.tb_deger.TabIndex = 32;
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(25, 132);
            this.nud_stok.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(266, 20);
            this.nud_stok.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Stok";
            // 
            // tb_varyasyonTuru
            // 
            this.tb_varyasyonTuru.FormattingEnabled = true;
            this.tb_varyasyonTuru.Items.AddRange(new object[] {
            "Beden",
            "Numara"});
            this.tb_varyasyonTuru.Location = new System.Drawing.Point(26, 38);
            this.tb_varyasyonTuru.Name = "tb_varyasyonTuru";
            this.tb_varyasyonTuru.Size = new System.Drawing.Size(265, 21);
            this.tb_varyasyonTuru.TabIndex = 36;
            // 
            // VariantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 226);
            this.Controls.Add(this.tb_varyasyonTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_deger);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.label1);
            this.Name = "VariantForm";
            this.Text = "VariantForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_deger;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tb_varyasyonTuru;
    }
}