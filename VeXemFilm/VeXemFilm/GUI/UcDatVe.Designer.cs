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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.txbSoGhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fpnlGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLichChieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.fpnlGhe.SuspendLayout();
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgrvLichChieu.Location = new System.Drawing.Point(6, 19);
            this.dgrvLichChieu.Name = "dgrvLichChieu";
            this.dgrvLichChieu.Size = new System.Drawing.Size(866, 183);
            this.dgrvLichChieu.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Giờ chiếu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên phim";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giá vé";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số vé còn lại";
            this.Column4.Name = "Column4";
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChieu.Location = new System.Drawing.Point(313, 3);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayChieu.TabIndex = 1;
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbTongTien);
            this.panel2.Controls.Add(this.txbSoGhe);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 94);
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
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(552, 59);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Location = new System.Drawing.Point(237, 59);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(75, 23);
            this.btnHuyVe.TabIndex = 5;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "In vé";
            this.button1.UseVisualStyleBackColor = true;
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
            // fpnlGhe
            // 
            this.fpnlGhe.AutoScroll = true;
            this.fpnlGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlGhe.Controls.Add(this.button5);
            this.fpnlGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlGhe.Location = new System.Drawing.Point(0, 243);
            this.fpnlGhe.Name = "fpnlGhe";
            this.fpnlGhe.Size = new System.Drawing.Size(884, 224);
            this.fpnlGhe.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "A1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // UcDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlGhe);
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
            this.fpnlGhe.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel fpnlGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Button button5;
    }
}
