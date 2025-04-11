using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RickStock_WindowsFormApp.Models;

namespace RickStock_WindowsFormApp
{
   
    public partial class LoginForm : Form
    {
        RickStockDB db = new RickStockDB();
        bool isLogin = false;
        public LoginForm()
        {
            InitializeComponent();
            tb_kullaniciadi.Text = "developer";
            tb_sifre.Text = "1234";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciadi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                Manager m = db.Managers.FirstOrDefault(x => x.Username == tb_kullaniciadi.Text && x.Password == tb_sifre.Text);
                if (m != null)
                {
                    isLogin = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin == false)
            {
                Application.Exit();
            }
        }
    }
}
