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


namespace VeXemFilm.GUI
{
    public partial class InThongKe : Form
    {
        DateTime start;
        DateTime end;
        List<ThongKeView> data = new List<ThongKeView>();
        public InThongKe(DateTime _start, DateTime _end, List<ThongKeView> _data)
        {
            InitializeComponent();
            start = _start;
            end = _end;
            data.AddRange(_data);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ThongKe rpt = new ThongKe();
            rpt.SetDataSource(data);
            decimal doanhthu =  data.Sum(x => x.DoanhThu);

            rpt.SetParameterValue("_doanhthu", VNCurrency.ToString(doanhthu));
            rpt.SetParameterValue("_doanhthuso", String.Format("{0:C}", doanhthu).Replace("$", "").Split('.')[0] + "đ");
            rpt.SetParameterValue("_start", start.ToString("dd/MM/yyyy"));
            rpt.SetParameterValue("_end", end.ToString("dd/MM/yyyy"));
            this.crystalReportViewer1.ReportSource = rpt;
        }
    }
}
