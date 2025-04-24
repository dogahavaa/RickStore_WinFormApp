namespace RickStock_WindowsFormApp
{
    partial class CategoryForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CMS_SilDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_upCategory = new System.Windows.Forms.Label();
            this.combobox_mainCategory = new System.Windows.Forms.ComboBox();
            this.cb_mainCategory = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CMS_SilDuzenle.SuspendLayout();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ContextMenuStrip = this.CMS_SilDuzenle;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(354, 217);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
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
            // groupbox
            // 
            this.groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox.Controls.Add(this.btn_duzenle);
            this.groupbox.Controls.Add(this.button1);
            this.groupbox.Controls.Add(this.lbl_upCategory);
            this.groupbox.Controls.Add(this.combobox_mainCategory);
            this.groupbox.Controls.Add(this.cb_mainCategory);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.tb_name);
            this.groupbox.Location = new System.Drawing.Point(390, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(398, 217);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Kategori İşlemleri";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.btn_duzenle.Location = new System.Drawing.Point(140, 156);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(223, 35);
            this.btn_duzenle.TabIndex = 9;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(141, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_upCategory
            // 
            this.lbl_upCategory.AutoSize = true;
            this.lbl_upCategory.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_upCategory.Location = new System.Drawing.Point(25, 116);
            this.lbl_upCategory.Name = "lbl_upCategory";
            this.lbl_upCategory.Size = new System.Drawing.Size(109, 20);
            this.lbl_upCategory.TabIndex = 7;
            this.lbl_upCategory.Text = "Üst Kategorisi";
            this.lbl_upCategory.Visible = false;
            // 
            // combobox_mainCategory
            // 
            this.combobox_mainCategory.FormattingEnabled = true;
            this.combobox_mainCategory.Location = new System.Drawing.Point(141, 115);
            this.combobox_mainCategory.Name = "combobox_mainCategory";
            this.combobox_mainCategory.Size = new System.Drawing.Size(225, 21);
            this.combobox_mainCategory.TabIndex = 6;
            this.combobox_mainCategory.Visible = false;
            // 
            // cb_mainCategory
            // 
            this.cb_mainCategory.AutoSize = true;
            this.cb_mainCategory.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_mainCategory.Location = new System.Drawing.Point(244, 26);
            this.cb_mainCategory.Name = "cb_mainCategory";
            this.cb_mainCategory.Size = new System.Drawing.Size(120, 24);
            this.cb_mainCategory.TabIndex = 5;
            this.cb_mainCategory.Text = "Ana Kategori";
            this.cb_mainCategory.UseVisualStyleBackColor = true;
            this.cb_mainCategory.CheckedChanged += new System.EventHandler(this.cb_mainCategory_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(140, 66);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(224, 20);
            this.tb_name.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 203);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.treeView1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.CMS_SilDuzenle.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_upCategory;
        private System.Windows.Forms.ComboBox combobox_mainCategory;
        private System.Windows.Forms.CheckBox cb_mainCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip CMS_SilDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.Button btn_duzenle;
    }
}