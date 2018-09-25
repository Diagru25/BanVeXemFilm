namespace VeXemFilm.GUI
{
    partial class UcThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnThongke = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.PhimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInBaoCao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateKetThuc);
            this.panel1.Controls.Add(this.dateBatDau);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 52);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đến ngày :";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKetThuc.Location = new System.Drawing.Point(473, 16);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(110, 20);
            this.dateKetThuc.TabIndex = 2;
            // 
            // dateBatDau
            // 
            this.dateBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBatDau.Location = new System.Drawing.Point(195, 16);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(110, 20);
            this.dateBatDau.TabIndex = 1;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(620, 13);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(97, 23);
            this.btnThongke.TabIndex = 0;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDoanhThu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 52);
            this.panel2.TabIndex = 3;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.Location = new System.Drawing.Point(433, 19);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(71, 17);
            this.lbDoanhThu.TabIndex = 1;
            this.lbDoanhThu.Text = "4,500,000đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongKe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 457);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhimID,
            this.Column2,
            this.Column1,
            this.TenPhim,
            this.ThoiLuong,
            this.KhoiChieu,
            this.Columnn});
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(3, 16);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(878, 438);
            this.dgvThongKe.TabIndex = 0;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(753, 13);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(97, 23);
            this.btnInBaoCao.TabIndex = 5;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // PhimID
            // 
            this.PhimID.DataPropertyName = "PhimID";
            this.PhimID.FillWeight = 150F;
            this.PhimID.HeaderText = "ID Phim";
            this.PhimID.Name = "PhimID";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "s_KhoiChieu";
            this.Column2.HeaderText = "KhoiChieus";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DoanhThu";
            this.Column1.HeaderText = "DoanhThu";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Width = 250;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời lượng (phút)";
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.Width = 120;
            // 
            // KhoiChieu
            // 
            this.KhoiChieu.DataPropertyName = "KhoiChieu";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            this.KhoiChieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.KhoiChieu.HeaderText = "Khởi chiếu";
            this.KhoiChieu.Name = "KhoiChieu";
            this.KhoiChieu.Width = 130;
            // 
            // Columnn
            // 
            this.Columnn.DataPropertyName = "sDoanhThu";
            this.Columnn.HeaderText = "Doanh Thu";
            this.Columnn.Name = "Columnn";
            this.Columnn.Width = 200;
            // 
            // UcThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcThongKe";
            this.Size = new System.Drawing.Size(884, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnn;
    }
}
