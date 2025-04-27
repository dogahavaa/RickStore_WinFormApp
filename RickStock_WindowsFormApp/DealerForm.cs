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
    public partial class DealerForm : Form
    {
        RickStockDB db = new RickStockDB();
        int bayilikRowindex = -1;
        int bayiRowindex = -1;
        public DealerForm()
        {
            InitializeComponent();
        }

        private void btn_BayilikTipiEkle_Click(object sender, EventArgs e)
        {
            DealerType dtype = new DealerType();
            if (!string.IsNullOrEmpty(tb_bayilikTipi.Text))
            {
                dtype.Name = tb_bayilikTipi.Text;
                dtype.DiscountRate = Convert.ToInt32(nud_indirimOrani.Value);
                db.DealerTypes.Add(dtype);
                db.SaveChanges();
                DGVBayilikTipiListele();
                CBBayilikTipiDoldur();
            }
        }
        private void DGVBayilikTipiListele()
        {
            List<DealerType> bayilikTipleri = db.DealerTypes.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Bayilik Tipi");
            dt.Columns.Add("İndirim Oranı");

            foreach (DealerType type in bayilikTipleri)
            {
                dt.Rows.Add(
                    type.ID,
                    type.Name,
                    type.DiscountRate
                    );
            }
            dgv_bayilikTipleri.DataSource = dt;
        }

        private void DGVBayiListele()
        {
            List<Dealer> bayiler = db.Dealers.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Bayi Adı");
            dt.Columns.Add("Website");
            dt.Columns.Add("Bayi Tipi");
            dt.Columns.Add("Aktif");
            dt.Columns.Add("Key");

            foreach (Dealer dealer in bayiler)
            {
                dt.Rows.Add(
                    dealer.ID,
                    dealer.Name,
                    dealer.Website,
                    dealer.DealerType.Name,
                    dealer.IsActive,
                    dealer.DealerTypeKey
                    );
            }
            dgv_bayiler.DataSource = dt;
        }

        private void CBBayilikTipiDoldur()
        {
            cb_bayiTipi.DataSource = db.DealerTypes.ToList();
            cb_bayiTipi.ValueMember = "ID";
            cb_bayiTipi.DisplayMember = "Name";
        }

        private void DealerForm_Load(object sender, EventArgs e)
        {
            DGVBayilikTipiListele();
            DGVBayiListele();
            CBBayilikTipiDoldur();
        }

        private void dgv_bayilikTipleri_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_bayilikTipleri.ClearSelection();
                bayilikRowindex = dgv_bayilikTipleri.HitTest(e.X, e.Y).RowIndex;
                if (bayilikRowindex != -1)
                {
                    CMS_SilDuzenle.Show(dgv_bayilikTipleri, e.X, e.Y);
                    dgv_bayilikTipleri.Rows[bayilikRowindex].Selected = true;
                }
            }
        }

        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            if (bayilikRowindex != -1)
            {
                int id = Convert.ToInt32(dgv_bayilikTipleri.Rows[bayilikRowindex].Cells[0].Value);
                DealerType dt = db.DealerTypes.Find(id);
                if (dt != null)
                {
                    btn_bayilikTipiDuzenle.Visible = true;
                    tb_bayilikTipi.Text = dt.Name;
                    nud_indirimOrani.Value = dt.DiscountRate;
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }

            if (bayiRowindex != -1)
            {
                int id = Convert.ToInt32(dgv_bayiler.Rows[bayiRowindex].Cells[0].Value);
                Dealer d = db.Dealers.Find(id);
                if (d != null)
                {
                    btn_bayiDuzenle.Visible = true;
                    tb_bayiAdi.Text = d.Name;
                    tb_website.Text = d.Website;
                    cb_bayiTipi.SelectedValue = d.DealerTypeID;
                    cbox_aktif.Checked = d.IsActive;
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }

        }

        private void btn_bayilikTipiDuzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_bayilikTipleri.Rows[bayilikRowindex].Cells[0].Value);
            DealerType dt = db.DealerTypes.Find(id);

            dt.Name = tb_bayilikTipi.Text;
            dt.DiscountRate = Convert.ToInt32(nud_indirimOrani.Value);
            db.SaveChanges();
            DGVBayilikTipiListele();

            tb_bayilikTipi.Text = "";
            nud_indirimOrani.Value = 0;
            btn_bayilikTipiDuzenle.Visible = false;
            CBBayilikTipiDoldur();
        }

        private void btn_BayiEkle_Click(object sender, EventArgs e)
        {
            Dealer d = new Dealer();
            if (!string.IsNullOrEmpty(tb_bayiAdi.Text))
            {
                d.Name = tb_bayiAdi.Text;
                d.Website = tb_website.Text;
                d.DealerTypeID = Convert.ToInt32(cb_bayiTipi.SelectedValue);
                d.DealerTypeKey = Guid.NewGuid().ToString();
                d.IsActive = cbox_aktif.Checked;
                db.Dealers.Add(d);
                db.SaveChanges();
                DGVBayiListele();

                tb_bayiAdi.Text = "";
                tb_website.Text = "";
                cbox_aktif.Checked = false;
            }
        }

        private void dgv_bayiler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_bayiler.ClearSelection();
                bayiRowindex = dgv_bayiler.HitTest(e.X, e.Y).RowIndex;
                if (bayiRowindex != -1)
                {
                    CMS_SilDuzenle.Show(dgv_bayiler, e.X, e.Y);
                    dgv_bayiler.Rows[bayiRowindex].Selected = true;
                }
            }
        }

        private void btn_bayiDuzenle_Click(object sender, EventArgs e)
        {

            int bayiid = Convert.ToInt32(dgv_bayiler.Rows[bayiRowindex].Cells[0].Value);
            Dealer d = db.Dealers.Find(bayiid);

            d.Name = tb_bayiAdi.Text;
            d.Website = tb_website.Text;
            d.DealerTypeID = Convert.ToInt32(cb_bayiTipi.SelectedValue);
            d.IsActive = cbox_aktif.Checked;
            db.SaveChanges();
            DGVBayiListele();

            tb_bayiAdi.Text = "";
            tb_website.Text = "";
            cbox_aktif.Checked = false;
            btn_bayiDuzenle.Visible = false;
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            if (bayilikRowindex != -1)
            {
                int id = Convert.ToInt32(dgv_bayilikTipleri.Rows[bayilikRowindex].Cells[0].Value);
                DealerType dt = db.DealerTypes.Find(id);
                if (dt != null)
                {
                    DialogResult sonuc = MessageBox.Show($"'{dt.Name}' tipini TAMAMEN silmek istiyor musun ?\nBu işlem geri alınamaz!", "Sil & Geri Al", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        db.DealerTypes.Remove(dt);
                        db.SaveChanges();
                        DGVBayilikTipiListele();
                    }
                }
                else
                {
                    MessageBox.Show("Bayilik bulunamadı.");
                }
            }

            if (bayiRowindex != -1)
            {
                int id = Convert.ToInt32(dgv_bayiler.Rows[bayiRowindex].Cells[0].Value);
                Dealer d = db.Dealers.Find(id);
                if (d != null)
                {
                    DialogResult sonuc = MessageBox.Show($"'{d.Name}' adlı bayiyi TAMAMEN silmek istiyor musun ?\nBu işlem geri alınamaz!", "Sil & Geri Al", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        db.Dealers.Remove(d);
                        db.SaveChanges();
                        DGVBayiListele();
                    }
                }
                else
                {
                    MessageBox.Show("Bayi bulunamadı.");
                }
            }
        }
    }
}
