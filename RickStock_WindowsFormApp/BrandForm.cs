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

namespace RickStock_WindowsFormApp
{
    public partial class BrandForm : Form
    {
        int rowindex = -1;
        RickStockDB db = new RickStockDB();
        string picturePath;
        string pictureName;
        string pictureExtension;
        bool resimSecildiMi = false;
        public BrandForm()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                Brand b = new Brand();
                b.Name = tb_isim.Text;
                b.IsActive = checkBox_aktif.Checked;
                if (resimSecildiMi)
                {
                    b.Logo = pictureName;
                    string targetPath = Path.Combine(@"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\BrandImages\", pictureName);
                    File.Copy(picturePath, targetPath, true);
                    resimSecildiMi = false;
                }
                else
                {
                    b.Logo = "noImage.png";
                }
                db.Brands.Add(b);
                db.SaveChanges();
                MarkaListele();

                tb_isim.Text = "";
                pb_resim.ImageLocation = @"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\add-image.png";
            }
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
                    resimSecildiMi = true;
                }
            }
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }
        private void MarkaListele()
        {
            dataGridView1.DataSource = db.Brands.ToList();
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

        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                Brand b = db.Brands.Find(id);
                if (b != null)
                {
                    btn_duzenle.Visible = true;
                    tb_isim.Text = b.Name;
                    checkBox_aktif.Checked = b.IsActive;
                    pb_resim.ImageLocation = @"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\BrandImages\" + b.Logo;
                }
                else
                {
                    MessageBox.Show("Marka bulunamadı.");
                }
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Brand b = db.Brands.Find(id);
            if (b != null)
            {
                if (!string.IsNullOrEmpty(tb_isim.Text))
                {
                    if (resimSecildiMi)
                    {
                        b.Logo = pictureName;
                        string targetPath = Path.Combine(@"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\BrandImages\", pictureName);
                        File.Copy(picturePath, targetPath, true);
                        resimSecildiMi = false;
                    }
                    b.Name = tb_isim.Text;
                    b.IsActive = checkBox_aktif.Checked;
                    db.SaveChanges();
                    tb_isim.Text = "";
                    pb_resim.ImageLocation = @"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\add-image.png";
                }
            }
            btn_duzenle.Visible = false;
            MarkaListele();
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Brand b = db.Brands.Find(id);
            if (b != null)
            {
                DialogResult sonuc = MessageBox.Show($"'{b.Name}' markasını silmek istiyor musun ?", "Sil", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    db.Brands.Remove(b);
                    db.SaveChanges();
                    MarkaListele();
                }
            }
        }
    }
}
