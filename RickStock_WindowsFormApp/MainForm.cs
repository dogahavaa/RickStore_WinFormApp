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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void TSMI_Urunler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(ProductForm))
                {
                    acikMi = true;
                    form.Activate();//Form Açılmışsa En Öne Getir
                }
            }
            if (acikMi == false)
            {
                ProductForm frm = new ProductForm();
                this.Size = new System.Drawing.Size(frm.Width, frm.Height + 30);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_MarkaIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(BrandForm))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                BrandForm frm = new BrandForm();
                this.Size = new System.Drawing.Size(frm.Width, frm.Height + 30);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_KategoriIslemleri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(CategoryForm))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                CategoryForm frm = new CategoryForm();
                this.Size = new System.Drawing.Size(frm.Width, frm.Height + 45);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void bayilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(DealerForm))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                DealerForm frm = new DealerForm();
                this.Size = new System.Drawing.Size(frm.Width, frm.Height + 45);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
    }
}
