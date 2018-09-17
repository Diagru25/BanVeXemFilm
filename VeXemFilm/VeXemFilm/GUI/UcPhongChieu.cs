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
    public partial class UcPhongChieu : UserControl
    {
        BindingSource list = new BindingSource();

        public UcPhongChieu()
        {
            InitializeComponent();
            dgrvPhongChieu.DataSource = list;
            loadPhongChieu();
            PhongChieuAddBinding();
            LockControl();
        }


        #region hàm chức năng
        private void loadPhongChieu()
        {
            list.DataSource = new PhongChieuDAO().GetAll();
        }
        private void LockControl()
        {
            txbMa.Enabled = false;
            txbViTri.Enabled = false;
            txbTen.Enabled = false;
            txbSoGhe.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
        }

        private void UnlockControl()
        {
            txbMa.Enabled = true;
            txbViTri.Enabled = true;
            txbTen.Enabled = true;
            txbSoGhe.Enabled = true;
        }

        private void EmptyControl()
        {
            txbMa.Text = "";
            txbViTri.Text = "";
            txbTen.Text = "";
            txbSoGhe.Text = "";
        }

        private void PhongChieuAddBinding()
        {
            txbMa.DataBindings.Add("Text", dgrvPhongChieu.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTen.DataBindings.Add("Text", dgrvPhongChieu.DataSource, "TenPhongChieu", true, DataSourceUpdateMode.Never);
            txbViTri.DataBindings.Add("Text", dgrvPhongChieu.DataSource, "ViTri", true, DataSourceUpdateMode.Never);
            txbSoGhe.DataBindings.Add("Text", dgrvPhongChieu.DataSource, "TongSoGhe", true, DataSourceUpdateMode.Never);
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
                PhongChieu item = new PhongChieu();
                item.TenPhongChieu = txbTen.Text;
                item.ViTri = txbViTri.Text;
                item.TongSoGhe = Convert.ToInt32(txbSoGhe.Text);

                if (new PhongChieuDAO().AddPhongChieu(item))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadPhongChieu();
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
                PhongChieu item = new PhongChieu();
                item.ID = Convert.ToInt32(txbMa.Text);
                item.TenPhongChieu = txbTen.Text;
                item.ViTri = txbViTri.Text;
                item.TongSoGhe = Convert.ToInt32(txbSoGhe.Text);

                if (new PhongChieuDAO().EditPhongChieu(item))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
                LockControl();
                loadPhongChieu();
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
                    bool result = new PhongChieuDAO().RemovePhongChieu(id);
                    if (result == true)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                    loadPhongChieu();
                    LockControl();
                }
                else
                    return;
            }
            else
            {
                loadPhongChieu();
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
