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

namespace VeXemFilm.GUI
{
    public partial class UcDatVe : UserControl
    {
        int checkID = 0;
        decimal gia = 0;
        public UcDatVe()
        {
            InitializeComponent();
            //CreateListBtn(ucClick);
        }

        #region khởi tạo
        private void LoadLichChieu(DateTime NgayChieu)
        {
            dgrvLichChieu.DataSource = new DatVeDAO().LichChieuTheoNgay(NgayChieu);
        }

        private void EmptyControl()
        {
            txbSoGhe.Clear();
            txbTongTien.Text = "0";
        }

        #endregion






        private void ucClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Enabled = false;
            txbSoGhe.Text += button.Text + "; ";
            txbTongTien.Text = (Convert.ToDecimal(txbTongTien.Text) + gia).ToString("N0");
        }

        private void CreateListBtn(EventHandler e, int tongsoghe, List<string> dsGheDaDat)
        {
            //xóa hết button
            fpnlGhe.Controls.Clear();
            EmptyControl();

            int total = tongsoghe;
            // vẽ các button theo hàng và cột (1 hàng có 17 ghế)
            for(int c = 65; c <= 65 + tongsoghe / 17; c++) 
                for (int i = 1; i < 18; i++)
                {

                    //khởi tạo button
                    Button btnGhe = new Button();
                    btnGhe.Width = 44;
                    btnGhe.Height = 45;
                    btnGhe.Name = "btn" + Convert.ToChar(c).ToString() + i;
                    btnGhe.Text = "" + Convert.ToChar(c).ToString() + i;

                    //kiểm tra xem ghế đó đã đặt chưa
                    if (dsGheDaDat.Contains(btnGhe.Text))
                    {
                        //nếu đặt rồi thì thêm ghế vào ô text và ẩn đi
                        txbSoGhe.Text += btnGhe.Text + "; ";
                        btnGhe.Enabled = false;
                    }

                    //gán sự kiện click cho button
                    btnGhe.Click += e;

                    //thêm button vào panel
                    fpnlGhe.Controls.Add(btnGhe);

                    // vẽ đủ số lương ghế thì out
                    if (--total == 0) break;
                }
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            DateTime NgayChieu = dtpNgayChieu.Value.Date;
            LoadLichChieu(NgayChieu);
        }

        private void dgrvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string tenphong = dgrvLichChieu.CurrentRow.Cells["PhongChieu"].Value.ToString();
            string tenphim = dgrvLichChieu.CurrentRow.Cells["TenPhim"].Value.ToString();
            string giochieu = dgrvLichChieu.CurrentRow.Cells["GioChieu"].Value.ToString();
            long phongchieuid = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["PhongChieuID"].Value.ToString());
            long phimid = Convert.ToInt32(Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["PhimID"].Value.ToString()));
            int tongsoghe = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["TongSoVe"].Value.ToString());
            int ID = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["ID"].Value.ToString());
            gia = Convert.ToDecimal(dgrvLichChieu.CurrentRow.Cells["GiaVe"].Value.ToString());

            //nếu trùng checkID có nghĩa là đang vẽ rồi, không vẽ lại nữa
            if (checkID == ID)
                return;

            // lấy ra danh sách ghế đã đặt của dòng được click
            List<string> li = new DatVeDAO().LaySoGheDaDat(dtpNgayChieu.Value.Date, phongchieuid, giochieu, phimid);

            // đổi tên group box
            grbGhe.Text = tenphong + " - " + tenphim;

            //vẽ các ghế trong phòng
            CreateListBtn(ucClick, tongsoghe, li);

            //gán lại checkID để kiểm tra trùng vào lần sau
            checkID = ID;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            //t add vào bảng vé ở đây

            //xong m in ra à :v
        }
    }
}
