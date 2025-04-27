using RickStock_WindowsFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RickStock_WindowsFormApp
{
    // ***** YAPILACAKLAR *******
    // Treeview'da seçilen kategoriye ait ürünleri dgv ile listele
    // Kategori adını Unique yap ve buradan kontrolünü sağla


    public partial class CategoryForm : Form
    {
        RickStockDB db = new RickStockDB();
        TreeNode selectedNode;
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                Category c = new Category();
                c.Name = tb_name.Text;
                if (!cb_mainCategory.Checked)
                {
                    c.UpCategoryID = Convert.ToInt32(combobox_mainCategory.SelectedValue);

                }
                db.Categories.Add(c);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComboboxDoldur();
            KategorileriGetir();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            KategorileriGetir();
            btn_duzenle.Visible = false;
            dgv_urunler.DataSource = null;
        }

        private void cb_mainCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mainCategory.Checked)
            {
                combobox_mainCategory.Visible = false;
                lbl_upCategory.Visible = false;
            }
            else
            {
                combobox_mainCategory.Visible = true;
                lbl_upCategory.Visible = true;
            }
        }

        // ********** TREEVIEW **********
        public void KategorileriGetir()
        {
            treeView1.Nodes.Clear();

            var categories = db.Categories.Where(c => c.UpCategoryID == null).ToList();

            foreach (var category in categories)
            {
                TreeNode mainNode = new TreeNode(category.Name)
                {
                    Tag = category.ID
                };
                treeView1.Nodes.Add(mainNode);

                AltKategorileriGetir(mainNode, category);
            }

            if (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes[0].Expand();
            }
            treeView1.ExpandAll();
        }

        private void AltKategorileriGetir(TreeNode parentNode, Category c)
        {
            List<Category> subCategories = db.Categories.Where(x => x.UpCategoryID == c.ID).ToList();

            foreach (Category subCategory in subCategories)
            {
                TreeNode subNode = new TreeNode(subCategory.Name)
                {
                    Tag = subCategory.ID
                };
                parentNode.Nodes.Add(subNode);
            }
        }
        // ********** TREEVIEW **********

        private void ComboboxDoldur()
        {
            cb_mainCategory.Checked = true;
            combobox_mainCategory.DataSource = db.Categories.Where(x => x.IsDeleted == false && x.IsActive == true && x.UpCategoryID == null).ToList();
            combobox_mainCategory.ValueMember = "ID";
            combobox_mainCategory.DisplayMember = "Name";
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedNode = treeView1.GetNodeAt(e.X, e.Y);
                if (selectedNode != null)
                {
                    treeView1.SelectedNode = selectedNode;
                }
            }
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            int categoryID = (int)selectedNode.Tag;
            Category c = db.Categories.Find(categoryID);
            if (c != null)
            {
                DialogResult sonuc = MessageBox.Show($"'{c.Name}' kategorisini silmek istiyor musun ?", "Sil", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    if (c.UpCategoryID == null) // Eğer ana kategori ise
                    {
                        List<Category> altkategoriler = db.Categories.Where(x => x.UpCategoryID == c.ID).ToList();

                        if (altkategoriler.Count > 0) // Eğer alt kategorisi var ise
                        {
                            DialogResult altsonuc = MessageBox.Show("Alt kategoriler de silinsin mi ?", "Sil", MessageBoxButtons.YesNo);
                            if (altsonuc == DialogResult.Yes) // Tüm alt kategorileri sil
                            {
                                foreach (Category item in altkategoriler)
                                {
                                    db.Categories.Remove(item);
                                }
                            }
                        }
                    }
                    db.Categories.Remove(c);
                    db.SaveChanges();
                    KategorileriGetir();
                    ComboboxDoldur();
                }
            }
            else
            {
                MessageBox.Show("Kategori bulunamadı.");
            }
        }

        // Kategoriyi Getir
        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            btn_duzenle.Visible = true;


            int categoryID = (int)selectedNode.Tag;
            Category c = db.Categories.Find(categoryID);
            if (c != null)
            {
                tb_name.Text = c.Name;
                if (c.UpCategoryID == null)
                {
                    cb_mainCategory.Checked = true;
                }
                else
                {
                    cb_mainCategory.Checked = false;
                    combobox_mainCategory.SelectedValue = Convert.ToInt32(c.UpCategoryID);
                }
            }
        }
        // Kategoriyi düzenle
        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            int categoryID = (int)selectedNode.Tag;
            Category c = db.Categories.Find(categoryID);

            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                c.Name = tb_name.Text;
                if (cb_mainCategory.Checked)
                {
                    c.UpCategoryID = null;
                }
                else
                {
                    c.UpCategoryID = Convert.ToInt32(combobox_mainCategory.SelectedValue);
                }
                db.SaveChanges();
                ComboboxDoldur();
                KategorileriGetir();
                btn_duzenle.Visible = false;
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node; // Seçilen node’u güncelle
            if (selectedNode != null)
            {
                int categoryID = (int)selectedNode.Tag; // Seçilen kategorinin ID’si
                UrunleriListele(categoryID); // Ürünleri listele
            }
        }
        private void UrunleriListele(int categoryID)
        {
            // Seçilen kategori ve alt kategorilerin ID’lerini topla
            List<int> categoryIDs = new List<int> { categoryID };
            categoryIDs.AddRange(GetSubCategoryIDs(categoryID));

            // Kategorilere ait ürünleri al
            var urunler = db.Products
                .Where(p => categoryIDs.Contains(p.CategoryID) && !p.IsDeleted)
                .ToList();

            // DataGridView’i doldur
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün İsmi");
            dt.Columns.Add("Açıklama");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Marka");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Aktif");

            foreach (Product urun in urunler)
            {
                dt.Rows.Add(
                    urun.ID,
                    urun.Name,
                    urun.Description,
                    urun.Price,
                    urun.Brand.Name,
                    urun.Category.Name,
                    urun.IsActive
                );
            }

            dgv_urunler.DataSource = dt;
        }

        private List<int> GetSubCategoryIDs(int categoryID)
        {
            List<int> subCategoryIDs = new List<int>();
            var subCategories = db.Categories.Where(c => c.UpCategoryID == categoryID).ToList();

            foreach (var subCategory in subCategories)
            {
                subCategoryIDs.Add(subCategory.ID);
                subCategoryIDs.AddRange(GetSubCategoryIDs(subCategory.ID)); // Özyinelemeli olarak alt kategorileri al
            }

            return subCategoryIDs;
        }
    }
}
