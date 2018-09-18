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
    public partial class UcPhim : UserControl
    {
        BindingSource list = new BindingSource();
        public UcPhim()
        {
            InitializeComponent();
            dgrvPhim.DataSource = list;
            loadPhim();
            PhimAddBinding();
            LockControl();
        }

        #region hàm chức năng
        private void loadPhim()
        {
            list.DataSource = new PhimDAO().GetAll();
        }

        private void LockControl()
        {
            txbMa.Enabled = false;
            txbMoTa.Enabled = false;
            txbTen.Enabled = false;
            txbThoiLuong.Enabled = false;
            dtpKhoiChieu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
        }

        private void UnlockControl()
        {
            txbMa.Enabled = true;
            txbMoTa.Enabled = true;
            txbTen.Enabled = true;
            txbThoiLuong.Enabled = true;
            dtpKhoiChieu.Enabled = true;
        }

        private void EmptyControl()
        {
            txbMa.Text = "";
            txbMoTa.Text = "";
            txbTen.Text = "";
            txbThoiLuong.Text = "";
            dtpKhoiChieu.Value = DateTime.Today;
        }

        private void PhimAddBinding()
        {
            txbMa.DataBindings.Add("Text", dgrvPhim.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTen.DataBindings.Add("Text", dgrvPhim.DataSource, "TenPhim", true, DataSourceUpdateMode.Never);
            txbMoTa.DataBindings.Add("Text", dgrvPhim.DataSource, "MoTa", true, DataSourceUpdateMode.Never);
            txbThoiLuong.DataBindings.Add("Text", dgrvPhim.DataSource, "ThoiLuong", true, DataSourceUpdateMode.Never);
            dtpKhoiChieu.DataBindings.Add("Value", dgrvPhim.DataSource, "KhoiChieu", true, DataSourceUpdateMode.Never);
        }
        #endregion

        #region Sự kiện 
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                UnlockControl();
                EmptyControl();
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
            }
            else
            {
                Phim item = new Phim();
                item.TenPhim = txbTen.Text;
                item.MoTa = txbMoTa.Text;
                item.ThoiLuong = Convert.ToInt32(txbThoiLuong.Text);
                item.KhoiChieu = dtpKhoiChieu.Value;

                if(new PhimDAO().AddPhim(item))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadPhim();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                UnlockControl();
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";
            }
            else
            {
                Phim item = new Phim();
                item.ID = Convert.ToInt32(txbMa.Text);
                item.TenPhim = txbTen.Text;
                item.MoTa = txbMoTa.Text;
                item.ThoiLuong = Convert.ToInt32(txbThoiLuong.Text);
                item.KhoiChieu = dtpKhoiChieu.Value;

                if (new PhimDAO().EditPhim(item))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadPhim();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    long id = Convert.ToInt32(txbMa.Text);
                    bool result = new PhimDAO().RemovePhim(id);
                    if (result == true)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                    loadPhim();
                    LockControl();
                }
                else
                    return;
            }
            else
            {
                loadPhim();
                LockControl();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #endregion
    }
}
