using RickStock_WindowsFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RickStock_WindowsFormApp
{
    // ***** YAPILACAKLAR *******
    // Düzenle tamamlanacak
    public partial class ProductForm : Form
    {
        RickStockDB db = new RickStockDB();
        string picturePath;
        string pictureName;
        string pictureExtension;
        bool pictureChange = false;
        int rowindex = -1;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
            GridViewDoldur();
        }

        private void GridViewDoldur()
        {
            List<Product> urunler = db.Products.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün İsmi");
            dt.Columns.Add("Açıklama");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Marka");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Aktif");
            dt.Columns.Add("Silinmiş");

            foreach (Product urun in urunler)
            {
                dt.Rows.Add(
                    urun.ID,
                    urun.Name,
                    urun.Description,
                    urun.Price,
                    urun.Brand.Name,
                    urun.Category.Name,
                    urun.IsActive,
                    urun.IsDeleted
                    );
            }

            dataGridView1.DataSource = dt;
        }

        private void ComboboxlariDoldur()
        {
            cb_kategoriler.DataSource = db.Categories.Where(x => x.IsDeleted == false && x.IsActive == true && x.UpCategory != null).ToList();
            cb_kategoriler.ValueMember = "ID";
            cb_kategoriler.DisplayMember = "DisplayName";

            cb_marka.DataSource = db.Brands.Where(x => x.IsDeleted == false && x.IsActive == true).ToList();
            cb_marka.ValueMember = "ID";
            cb_marka.DisplayMember = "Name";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = tb_urunAdi.Text;
            p.BarcodeNo = tb_barkodno.Text;
            p.Price = nud_fiyat.Value;
            p.Description = tb_aciklama.Text;
            p.IsActive = checkBox_aktif.Checked;

            if (pictureChange)
            {
                p.Image = pictureName;
                string targetPath = Path.Combine(Application.StartupPath, "Assets", "Images", "ProductImages", pictureName);
                File.Copy(picturePath, targetPath, true);
            }
            else
            {
                p.Image = "noImage.png";
            }


            p.CategoryID = Convert.ToInt32(cb_kategoriler.SelectedValue);
            p.BrandID = Convert.ToInt32(cb_marka.SelectedValue);

            db.Products.Add(p);
            db.SaveChanges();
            ComboboxlariDoldur();
            GridViewDoldur();
        }

        private void pb_resim_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
                ofd.Title = "Ürün Resmi Seç";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    picturePath = fi.FullName;
                    pictureExtension = fi.Extension;

                    //Picturebox resmini değiştir.
                    pb_resim.ImageLocation = picturePath;

                    pictureName = Guid.NewGuid().ToString() + pictureExtension;
                    pictureChange = true;
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    CMS_SilDuzenle.Show(dataGridView1, e.X, e.Y);
                    dataGridView1.Rows[rowindex].Selected = true;
                }
            }
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Product p = db.Products.Find(id);
            if (p != null)
            {
                DialogResult sonuc = MessageBox.Show($"'{p.Name}' ürününü silmek veya geri almak istiyor musun ?", "Sil & Geri Al", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    p.IsDeleted = !p.IsDeleted;
                    db.SaveChanges();
                    GridViewDoldur();
                }
            }
        }

        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                Product p = db.Products.Find(id);
                if (p != null)
                {
                    btn_duzenle.Visible = true;
                    tb_barkodno.Text = p.BarcodeNo;
                    tb_urunAdi.Text = p.Name;
                    nud_fiyat.Value = p.Price;
                    tb_aciklama.Text = p.Description;
                    checkBox_aktif.Checked = p.IsActive;
                    pb_resim.ImageLocation = @"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\ProductImages\" + p.Image;
                    cb_kategoriler.SelectedValue = p.CategoryID;
                    cb_marka.SelectedValue = p.BrandID;
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }
        }

        private void yokEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Product p = db.Products.Find(id);
            if (p != null)
            {
                DialogResult sonuc = MessageBox.Show($"'{p.Name}' ürününü TAMAMEN silmek istiyor musun ?\nBu işlem geri alınamaz!", "Sil & Geri Al", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    db.Products.Remove(p);
                    db.SaveChanges();
                    GridViewDoldur();
                }
            }
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            string xmlKlasorYolu = @"C:\BayilikXML\";
            if (!Directory.Exists(xmlKlasorYolu))
            {
                Directory.CreateDirectory(xmlKlasorYolu);
            }

            List<DealerType> bayiTipleri = db.DealerTypes.ToList();
            List<Product> urunler = db.Products.ToList();
            foreach (var bayiTipi in bayiTipleri)
            {
                XDocument doc = new XDocument(
                    new XElement("BayiTipi",
                        new XAttribute("TipAdi", bayiTipi.Name),
                        new XElement("Urunler",
                            urunler.Select(urun => new XElement("Urun",
                                new XElement("BarkodNo", urun.BarcodeNo),
                                new XElement("UrunAdi", urun.Name),
                                new XElement("Aciklama", urun.Description),
                                new XElement("Kategori", urun.Category.Name),
                                new XElement("Marka", urun.Brand.Name),
                                new XElement("ResimAdi", urun.Image),
                                //new XElement("Fiyat", (((100-bayiTipi.DiscountRate) / 100)) ),
                                new XElement("Fiyat", urun.Price * Convert.ToDecimal(((100 - Convert.ToInt32(bayiTipi.DiscountRate)) / 100.00))),
                                new XElement("OlusturmaTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            ))
                        )
                    )
                );

                string dosyaYolu = Path.Combine(xmlKlasorYolu, bayiTipi.Name + ".xml");
                doc.Save(dosyaYolu);
            }
            MessageBox.Show("XML Dökümanı Hazır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
