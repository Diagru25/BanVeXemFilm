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
    public partial class UcTheLoai : UserControl
    {
        BindingSource list = new BindingSource();
        public UcTheLoai()
        {
            InitializeComponent();
            dgrvTheLoai.DataSource = list;
            loadTheLoai();
            TheLoaiAddBinding();
            LockControl();
        }

        #region hàm chức năng
        private void loadTheLoai()
        {
            list.DataSource = new TheLoaiDAO().GetAll();
        }
        private void LockControl()
        {
            txbMa.Enabled = false;
            txbGhiChu.Enabled = false;
            txbTen.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
        }

        private void UnlockControl()
        {
            txbMa.Enabled = true;
            txbGhiChu.Enabled = true;
            txbTen.Enabled = true;
        }

        private void EmptyControl()
        {
            txbMa.Text = "";
            txbGhiChu.Text = "";
            txbTen.Text = "";
        }

        private void TheLoaiAddBinding()
        {
            txbMa.DataBindings.Add("Text", dgrvTheLoai.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTen.DataBindings.Add("Text", dgrvTheLoai.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never);
            txbGhiChu.DataBindings.Add("Text", dgrvTheLoai.DataSource, "GhiChu", true, DataSourceUpdateMode.Never);
        }
        #endregion


        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                UnlockControl();
                EmptyControl();
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
            }
            else
            {
                TheLoai item = new TheLoai();
                item.TenTheLoai = txbTen.Text;
                item.GhiChu = txbGhiChu.Text;

                if (new TheLoaiDAO().AddTheLoai(item))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadTheLoai();
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
                TheLoai item = new TheLoai();
                item.ID = Convert.ToInt32(txbMa.Text);
                item.TenTheLoai = txbTen.Text;
                item.GhiChu = txbGhiChu.Text;

                if (new TheLoaiDAO().EditTheLoai(item))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadTheLoai();
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
                    bool result = new TheLoaiDAO().RemoveTheLoai(id);
                    if (result == true)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                    loadTheLoai();
                    LockControl();
                }
                else
                    return;
            }
            else
            {
                loadTheLoai();
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
