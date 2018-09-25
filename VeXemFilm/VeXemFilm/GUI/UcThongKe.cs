using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeXemFilm.DAO;
using VeXemFilm.Model.View;

namespace VeXemFilm.GUI
{
    public partial class UcThongKe : UserControl
    {
        public UcThongKe()
        {
            InitializeComponent();
            lbDoanhThu.Text = "";
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            List<ThongKeView> data = new PhimDAO().ThongKe(dateBatDau.Value, dateKetThuc.Value);
            dgvThongKe.DataSource = data;
            lbDoanhThu.Text = String.Format("{0:C}", data.Sum(x => x.DoanhThu)).Replace("$", "").Split('.')[0] + "đ";
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            InThongKe f = new InThongKe(dateBatDau.Value,dateKetThuc.Value,new PhimDAO().ThongKe(dateBatDau.Value, dateKetThuc.Value));
            f.ShowDialog();
        }
    }
}
