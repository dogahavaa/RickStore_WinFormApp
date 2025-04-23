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
    public partial class ProductForm : Form
    {
        RickStockDB db = new RickStockDB();
        string picturePath;
        string pictureName;
        string pictureExtension;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            cb_kategoriler.DataSource = db.Categories.Where(x => x.IsDeleted == false && x.IsActive == true && x.UpCategory != null).ToList();
            cb_kategoriler.ValueMember = "ID";
            cb_kategoriler.DisplayMember = "DisplayName";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = tb_urunAdi.Text;
            p.BarcodeNo = tb_barkodno.Text;
            p.Price = nud_fiyat.Value;
            p.Image = pictureName;

            string targetPath = Path.Combine(@"C:\Users\doga\Documents\GitHub\RickStore_WinFormApp\RickStock_WindowsFormApp\Assets\Images\ProductImages\", pictureName);
            File.Copy(picturePath, targetPath, true);
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
                }
            }
        }
    }
}
