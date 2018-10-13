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
using VeXemFilm.Model.EF;
using VeXemFilm.Model.View;

namespace VeXemFilm.GUI
{
    public partial class UcDatVe : UserControl
    {
        int checkID = 0, tongsoghe = 0;
        decimal gia = 0;
        long phongchieuid, phimid;
        TimeSpan thoigianbatdau, thoigianketthuc;
        List<VeView> ListVe = new List<VeView>();
        public UcDatVe()
        {
            InitializeComponent();
            EmptyControl();
        }

        #region khởi tạo và chức năng
        private void LoadLichChieu(DateTime NgayChieu, string TenPhim = "")
        {
            dgrvLichChieu.DataSource = new DatVeDAO().LichChieuTheoNgay(NgayChieu, TenPhim);
        }

        private void EmptyControl()
        {
            txbSoGhe.Clear();
            txbTongTien.Text = "0";
            btnDatVe.Enabled = false;
            btnHuyVe.Enabled = false;
        }

        private void disableButton(int tag)
        {
            foreach (Control ctr in fpnlGhe.Controls)
            {
                Button item = (Button)ctr;

                if ((int)item.Tag != tag)
                    item.Enabled = false;

            }
        }

        private void EnableButton()
        {
            foreach (Control ctr in fpnlGhe.Controls)
            {
                Button item = (Button)ctr;

                    item.Enabled = true;
            }
        }

        private void reload()
        {
            EmptyControl();
            LoadLichChieu(dtpNgayChieu.Value.Date);
        }
        #endregion

        #region sự kiện

        // tạo sự kiện click cho các button thêm = code
        private void ucClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Enabled = false;

            disableButton((int)button.Tag);

            if ((int)button.Tag == 0)
            {
                btnDatVe.Enabled = true;
                btnHuyVe.Enabled = false;
            }
            else
            {
                btnDatVe.Enabled = false;
                btnHuyVe.Enabled = true;
            }

            txbSoGhe.Text += button.Text + "; ";
            txbTongTien.Text = (Convert.ToDecimal(txbTongTien.Text) + gia).ToString("N0");
        }

        // hàm vẽ button ghế
        private void CreateListBtn(EventHandler e, int tongsoghe, List<string> dsGheDaDat)
        {
            //xóa hết button
            fpnlGhe.Controls.Clear();
            EmptyControl();

            int total = tongsoghe;
            // vẽ các button theo hàng và cột (1 hàng có 17 ghế)
            for (int c = 65; c <= 65 + tongsoghe / 17; c++)
                for (int i = 1; i < 18; i++)
                {

                    //khởi tạo button
                    Button btnGhe = new Button();
                    btnGhe.FlatStyle = FlatStyle.Flat;
                    btnGhe.Width = 44;
                    btnGhe.Height = 45;
                    btnGhe.Name = "btn" + Convert.ToChar(c).ToString() + i;
                    btnGhe.Text = "" + Convert.ToChar(c).ToString() + i;

                    // tag = 0 là chưa đặt chỗ, tag = 1 là đã đặt rồi
                    btnGhe.Tag = 0;

                    //kiểm tra xem ghế đó đã đặt chưa
                    if (dsGheDaDat.Contains(btnGhe.Text))
                    {
                        //nếu đặt rồi thì thêm ghế vào ô text và ẩn đi
                        btnGhe.Tag = 1;
                        btnGhe.BackColor = Color.DimGray;
                    }

                    //gán sự kiện click cho button
                    btnGhe.Click += e;

                    //thêm button vào panel
                    fpnlGhe.Controls.Add(btnGhe);

                    // vẽ đủ số lương ghế thì out
                    if (--total == 0) break;
                }
        }

        // sự kiện chọn ngày
        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
            DateTime NgayChieu = dtpNgayChieu.Value.Date;
            LoadLichChieu(NgayChieu);
        }

        //chọn các dòng trong bảng
        private void dgrvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string tenphong = dgrvLichChieu.CurrentRow.Cells["PhongChieu"].Value.ToString();
            string tenphim = dgrvLichChieu.CurrentRow.Cells["TenPhim"].Value.ToString();
            thoigianbatdau = (TimeSpan)dgrvLichChieu.CurrentRow.Cells["tgBatDau"].Value;
            thoigianketthuc = (TimeSpan)dgrvLichChieu.CurrentRow.Cells["tgKetThuc"].Value;
            phongchieuid = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["PhongChieuID"].Value.ToString());
            phimid = Convert.ToInt32(Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["PhimID"].Value.ToString()));
            tongsoghe = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["TongSoVe"].Value.ToString());
            int ID = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["ID"].Value.ToString());
            gia = Convert.ToDecimal(dgrvLichChieu.CurrentRow.Cells["GiaVe"].Value.ToString());

            //nếu trùng checkID có nghĩa là đang vẽ rồi, không vẽ lại nữa
            if (checkID == ID)
                return;

            // lấy ra danh sách ghế đã đặt của dòng được click
            List<string> li = new DatVeDAO().LaySoGheDaDat(dtpNgayChieu.Value.Date, phongchieuid, thoigianbatdau, thoigianketthuc, phimid);

            // đổi tên group box
            grbGhe.Text = tenphong + " - " + tenphim;

            //vẽ các ghế trong phòng
            CreateListBtn(ucClick, tongsoghe, li);

            //gán lại checkID để kiểm tra trùng vào lần sau
            checkID = ID;

        }

        // nhấn nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmptyControl();
                LoadLichChieu(dtpNgayChieu.Value.Date, txbTimKiem.Text);
            }
            catch
            {

            }
        }

        //nhấn nút đặt vé
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            //t add vào bảng vé ở đây
            long idLichChieu = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["ID"].Value.ToString());
            DateTime NgayMua = DateTime.Today.Date;
            string[] dsGhe = txbSoGhe.Text.Split(';');

            if (dsGhe.Length == 0)
                return;
            try
            {
                for (int i = 0; i < dsGhe.Length - 1; i++)
                {
                    Ve item = new Ve();
                    item.LichChieuID = idLichChieu;
                    item.NgayMua = NgayMua;
                    item.SoGhe = dsGhe[i].Trim();

                    VeView ve = new VeView();
                    ve.ID = new VeDAO().AddVe(item); // add vào bảng vé

                    // sau đó là in vé
                    ve.GiaVe = Convert.ToDecimal(dgrvLichChieu.CurrentRow.Cells["GiaVe"].Value.ToString());
                    ve.Ngay = dtpNgayChieu.Value.Date;
                    ve.PhongChieu = dgrvLichChieu.CurrentRow.Cells["PhongChieu"].Value.ToString();
                    ve.SoGhe = item.SoGhe;
                    ve.TenPhim = dgrvLichChieu.CurrentRow.Cells["TenPhim"].Value.ToString();
                    ve.BatDau = (TimeSpan)dgrvLichChieu.CurrentRow.Cells["tgBatDau"].Value;
                    InVe f = new InVe(ve);
                    f.ShowDialog();
                }
                reload();
                CreateListBtn(ucClick, tongsoghe, new DatVeDAO().LaySoGheDaDat(dtpNgayChieu.Value.Date, phongchieuid, thoigianbatdau, thoigianketthuc, phimid));
            }
            catch
            {
                MessageBox.Show("Lỗi bất ngờ");
            }
        }


        //nhấn nút làm lại
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            EmptyControl();
            EnableButton();
        }


        //nhấn nút hủy vé
        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            long idLichChieu = Convert.ToInt32(dgrvLichChieu.CurrentRow.Cells["ID"].Value.ToString());
            string[] dsGhe = txbSoGhe.Text.Split(';');

            if (dsGhe.Length == 0)
                return;
            try
            {
                for (int i = 0; i < dsGhe.Length - 1; i++)
                {                   
                    new VeDAO().RemoveVe(dtpNgayChieu.Value.Date, phongchieuid, thoigianbatdau, thoigianketthuc, phimid, dsGhe[i].Trim());
                }
                reload();
                CreateListBtn(ucClick, tongsoghe, new DatVeDAO().LaySoGheDaDat(dtpNgayChieu.Value.Date, phongchieuid, thoigianbatdau, thoigianketthuc, phimid));
            }
            catch
            {
                MessageBox.Show("Lỗi bất ngờ");
            }
        }

        #endregion
    }
}

/* 
 * Ghế đã đặt có màu xám đen 
 * Ghế chưa đặt sẽ có Tag = 0
 * Ghế đã đặt sẽ có Tag = 1
 * Không được chọn cả ghế đặt rồi và chưa đặt
 * Khi đã chọn ghế đặt rồi thì button In vé => disable
 * Khi đã chọn ghế chưa đặt thì button Hủy vé => disable
 * load lại lúc in hoặc hủy vé xong (cả button)
 */
