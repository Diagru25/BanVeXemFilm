using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeXemFilm.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string text = cboQuanLy.Text;
            pnlMain.Controls.Clear();
            switch (text)
            {
                case "Đặt vé":
                    UcDatVe uc = new UcDatVe();
                    uc.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc);
                    break;

                case "Lịch chiếu":
                    UcLichChieu uc1 = new UcLichChieu();
                    uc1.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc1);
                    break;

                case "Phim":
                    UcPhim uc2 = new UcPhim();
                    uc2.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc2);
                    break;


                case "Vé":
                    UcVe uc3 = new UcVe();
                    uc3.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc3);
                    break;

                case "Phòng chiếu":
                    UcPhongChieu uc4 = new UcPhongChieu();
                    uc4.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc4);
                    break;
                case "Thống kê":
                    UcThongKe uc5 = new UcThongKe();
                    uc5.Dock = DockStyle.Fill;
                    pnlMain.Controls.Add(uc5);
                    break;

                default: break;

            }

        }
    }
}
