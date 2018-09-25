using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeXemFilm.GUI;
using VeXemFilm.Model.EF;

namespace VeXemFilm
{
    public partial class FrmDangNhap : Form
    {
        VeXemPhimDbContext db = null;
        public FrmDangNhap()
        {
            InitializeComponent();
            db = new VeXemPhimDbContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string pass = txbpass.Text;
            Account item = db.Accounts.Where(x => x.Username == username && x.Password == pass).SingleOrDefault();
            if (item != null)
            {
                Form frm = new FrmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
