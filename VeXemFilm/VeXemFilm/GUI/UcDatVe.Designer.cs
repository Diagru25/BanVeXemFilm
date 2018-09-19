namespace VeXemFilm.GUI
{
    partial class UcDatVe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrvLichChieu = new System.Windows.Forms.DataGridView();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongChieuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoVeConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.txbSoGhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbGhe = new System.Windows.Forms.GroupBox();
            this.fpnlGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLichChieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbGhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpNgayChieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 243);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvLichChieu);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu";
            // 
            // dgrvLichChieu
            // 
            this.dgrvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLichChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GioChieu,
            this.ID,
            this.PhimID,
            this.TongSoVe,
            this.tgBatDau,
            this.tgKetThuc,
            this.PhongChieuID,
            this.PhongChieu,
            this.TenPhim,
            this.GiaVe,
            this.SoVeConLai,
            this.TongSoGhe});
            this.dgrvLichChieu.Location = new System.Drawing.Point(6, 19);
            this.dgrvLichChieu.Name = "dgrvLichChieu";
            this.dgrvLichChieu.ReadOnly = true;
            this.dgrvLichChieu.Size = new System.Drawing.Size(866, 183);
            this.dgrvLichChieu.TabIndex = 0;
            this.dgrvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvLichChieu_CellClick);
            // 
            // GioChieu
            // 
            this.GioChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioChieu.DataPropertyName = "GioChieu";
            this.GioChieu.HeaderText = "Giờ chiếu";
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PhimID
            // 
            this.PhimID.DataPropertyName = "PhimID";
            this.PhimID.HeaderText = "PhimID";
            this.PhimID.Name = "PhimID";
            this.PhimID.ReadOnly = true;
            this.PhimID.Visible = false;
            // 
            // TongSoVe
            // 
            this.TongSoVe.DataPropertyName = "TongSoVe";
            this.TongSoVe.HeaderText = "TongSoVe";
            this.TongSoVe.Name = "TongSoVe";
            this.TongSoVe.ReadOnly = true;
            this.TongSoVe.Visible = false;
            // 
            // tgBatDau
            // 
            this.tgBatDau.DataPropertyName = "tgBatDau";
            this.tgBatDau.HeaderText = "tgBatDau";
            this.tgBatDau.Name = "tgBatDau";
            this.tgBatDau.ReadOnly = true;
            this.tgBatDau.Visible = false;
            // 
            // tgKetThuc
            // 
            this.tgKetThuc.DataPropertyName = "tgKetThuc";
            this.tgKetThuc.HeaderText = "tgKetThuc";
            this.tgKetThuc.Name = "tgKetThuc";
            this.tgKetThuc.ReadOnly = true;
            this.tgKetThuc.Visible = false;
            // 
            // PhongChieuID
            // 
            this.PhongChieuID.DataPropertyName = "PhongChieuID";
            this.PhongChieuID.HeaderText = "PhongChieuID";
            this.PhongChieuID.Name = "PhongChieuID";
            this.PhongChieuID.ReadOnly = true;
            this.PhongChieuID.Visible = false;
            // 
            // PhongChieu
            // 
            this.PhongChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhongChieu.DataPropertyName = "PhongChieu";
            this.PhongChieu.HeaderText = "Phòng chiếu";
            this.PhongChieu.Name = "PhongChieu";
            this.PhongChieu.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // GiaVe
            // 
            this.GiaVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // SoVeConLai
            // 
            this.SoVeConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoVeConLai.DataPropertyName = "SoVeConLai";
            this.SoVeConLai.HeaderText = "Số vé còn lại";
            this.SoVeConLai.Name = "SoVeConLai";
            this.SoVeConLai.ReadOnly = true;
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.DataPropertyName = "TongSoGhe";
            this.TongSoGhe.HeaderText = "TongSoGhe";
            this.TongSoGhe.Name = "TongSoGhe";
            this.TongSoGhe.ReadOnly = true;
            this.TongSoGhe.Visible = false;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChieu.Location = new System.Drawing.Point(313, 3);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayChieu.TabIndex = 1;
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dtpNgayChieu_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnLamLai);
            this.panel2.Controls.Add(this.btnHuyVe);
            this.panel2.Controls.Add(this.btnDatVe);
            this.panel2.Controls.Add(this.txbTongTien);
            this.panel2.Controls.Add(this.txbSoGhe);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 88);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(714, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(552, 59);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Location = new System.Drawing.Point(237, 59);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(75, 23);
            this.btnHuyVe.TabIndex = 5;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.UseVisualStyleBackColor = true;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(75, 59);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(75, 23);
            this.btnDatVe.TabIndex = 4;
            this.btnDatVe.Text = "In vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(552, 16);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(237, 20);
            this.txbTongTien.TabIndex = 3;
            // 
            // txbSoGhe
            // 
            this.txbSoGhe.Location = new System.Drawing.Point(75, 16);
            this.txbSoGhe.Name = "txbSoGhe";
            this.txbSoGhe.ReadOnly = true;
            this.txbSoGhe.Size = new System.Drawing.Size(237, 20);
            this.txbSoGhe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số ghế";
            // 
            // grbGhe
            // 
            this.grbGhe.Controls.Add(this.fpnlGhe);
            this.grbGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbGhe.Location = new System.Drawing.Point(0, 243);
            this.grbGhe.Name = "grbGhe";
            this.grbGhe.Size = new System.Drawing.Size(884, 230);
            this.grbGhe.TabIndex = 2;
            this.grbGhe.TabStop = false;
            this.grbGhe.Text = "Phòng chiếu";
            // 
            // fpnlGhe
            // 
            this.fpnlGhe.AutoScroll = true;
            this.fpnlGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlGhe.Location = new System.Drawing.Point(3, 16);
            this.fpnlGhe.Name = "fpnlGhe";
            this.fpnlGhe.Size = new System.Drawing.Size(878, 211);
            this.fpnlGhe.TabIndex = 3;
            // 
            // UcDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbGhe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcDatVe";
            this.Size = new System.Drawing.Size(884, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLichChieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbGhe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvLichChieu;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSoGhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.GroupBox grbGhe;
        private System.Windows.Forms.FlowLayoutPanel fpnlGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongChieuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVeConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
    }
}
