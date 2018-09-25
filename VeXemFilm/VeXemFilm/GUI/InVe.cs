using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeXemFilm.Model.View;
using VeXemFilm.DAO;

namespace VeXemFilm.GUI
{
    public partial class InVe : Form
    {
        VeView ve = new VeView();
        public InVe(VeView _ve)
        {
            InitializeComponent();
            ve = _ve;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Ticket rpt = new Ticket();
            rpt.SetParameterValue("ID", ve.ID);
            rpt.SetParameterValue("TenPhim", ve.TenPhim);
            rpt.SetParameterValue("Ngay", ve.Ngay.ToString("dd - MM - yyyy"));
            rpt.SetParameterValue("PhongChieu", ve.PhongChieu);
            rpt.SetParameterValue("SoGhe", ve.SoGhe);
            rpt.SetParameterValue("BatDau", ve.BatDau.ToString(@"hh\:mm"));
            rpt.SetParameterValue("GiaVe",String.Format("{0:C}",ve.GiaVe).Replace("$","").Split('.')[0]);
            this.crystalReportViewer1.ReportSource = rpt;
        }
    }
}
