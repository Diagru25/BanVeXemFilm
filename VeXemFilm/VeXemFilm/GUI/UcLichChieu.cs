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

namespace VeXemFilm.GUI
{
    public partial class UcLichChieu : UserControl
    {
        BindingSource list = new BindingSource();
        public UcLichChieu()
        {
            InitializeComponent();
            dgrvLichChieu.DataSource = list;
            LockControl(true);
            LoadData(DateTime.Today);
            cboPhongChieu.DataSource = new PhongChieuDAO().GetAll();
            cboPhongChieu.DisplayMember = "TenPhongChieu";
            cboPhongChieu.ValueMember = "ID";
            LichChieuBinding();
        }

        void LoadData(DateTime date)
        {
            dtpNgayChieu.Value = date;
            list.DataSource = new LichChieuDAO().LichChieuDetails().Where(x => x.NgayChieu == date).ToList();
            dgrvLichChieu.DataSource = list;

            cboPhim.DataSource = new PhimDAO().GetAll().Where(x => x.KhoiChieu <= date).ToList();
            cboPhim.ValueMember = "ID";
            cboPhim.DisplayMember = "TenPhim";

        }

        void LichChieuBinding()
        {
            txbMa.DataBindings.Add("Text", dgrvLichChieu.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTgBatDau.DataBindings.Add("Text", dgrvLichChieu.DataSource, "ThoiGianBatDau", true, DataSourceUpdateMode.Never);
            txbTgKetThuc.DataBindings.Add("Text", dgrvLichChieu.DataSource, "ThoiGianKetThuc", true, DataSourceUpdateMode.Never);
            txbGiaVe.DataBindings.Add("Text", dgrvLichChieu.DataSource, "GiaVe", true, DataSourceUpdateMode.Never);
            cboPhongChieu.DataBindings.Add("SelectedValue", dgrvLichChieu.DataSource, "IDPhongChieu", true, DataSourceUpdateMode.Never);
            cboPhim.DataBindings.Add("SelectedValue", dgrvLichChieu.DataSource, "IDPhim", true, DataSourceUpdateMode.Never);
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            dgrvLichChieu.DataSource = new LichChieuDAO().LichChieuDetails().Where(x => x.NgayChieu <= dtpNgayChieu.Value.Date).ToList();
        }

        void LockControl(bool status)
        {
            cboPhim.Enabled = !status;
            txbTgBatDau.ReadOnly = status;
            txbTgKetThuc.ReadOnly = status;
            cboPhongChieu.Enabled = !status;
            txbGiaVe.ReadOnly = status;
        }
        void ClearText()
        {
            txbMa.Text = "";
            txbGiaVe.Text = "";
            txbTgBatDau.Text = "";
            txbTgKetThuc.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                ClearText();
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnSua.Enabled = false;
                btnThoat.Enabled = false;
                LockControl(false);
            }
            else
            {
                LichChieu item = new LichChieu();
                try
                {
                    item.GiaVe = Convert.ToDecimal(txbGiaVe.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai giá vé !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    item.ThoiGianBatDau = TimeSpan.Parse(txbTgBatDau.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai thời gian bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    item.ThoiGianKetThuc = TimeSpan.Parse(txbTgKetThuc.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                item.NgayChieu = dtpNgayChieu.Value.Date;
                item.PhimID = Convert.ToInt32(cboPhim.SelectedValue);
                item.PhongChieuID = Convert.ToInt32(cboPhongChieu.SelectedValue);
                bool res = new LichChieuDAO().Insert(item);
                if (!res)
                {
                    MessageBox.Show("Có lỗi xảy ra !", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(dtpNgayChieu.Value.Date);
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    btnSua.Enabled = true;
                    btnThoat.Enabled = true;
                    LockControl(true);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;
                btnThoat.Enabled = false;
                LockControl(false);
            }
            else
            {
                LichChieu item = new LichChieu();
                item.ID = Convert.ToInt32(txbMa.Text);
                try
                {
                    item.GiaVe = Convert.ToDecimal(txbGiaVe.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai giá vé !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    item.ThoiGianBatDau = TimeSpan.Parse(txbTgBatDau.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai thời gian bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    item.ThoiGianKetThuc = TimeSpan.Parse(txbTgKetThuc.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                item.NgayChieu = dtpNgayChieu.Value.Date;
                item.PhimID = Convert.ToInt32(cboPhim.SelectedValue);
                item.PhongChieuID = Convert.ToInt32(cboPhongChieu.SelectedValue);
                bool res = new LichChieuDAO().Edit(item);
                if (!res)
                {
                    MessageBox.Show("Có lỗi xảy ra !", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(dtpNgayChieu.Value.Date);
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    btnThem.Enabled = true;
                    btnThoat.Enabled = true;
                    LockControl(true);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool result = new LichChieuDAO().Delete(Convert.ToInt32(txbMa.Text));
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(dtpNgayChieu.Value.Date);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                LockControl(true);
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Text = "Xóa";
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnThoat.Enabled = true;
            }
        }
    }
}

