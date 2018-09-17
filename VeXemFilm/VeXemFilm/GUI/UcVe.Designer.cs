namespace VeXemFilm.GUI
{
    partial class UcVe
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
            this.txbMaLichChieu = new System.Windows.Forms.TextBox();
            this.txbSoGhe = new System.Windows.Forms.TextBox();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrvVe = new System.Windows.Forms.DataGridView();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvVe)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMaLichChieu
            // 
            this.txbMaLichChieu.Location = new System.Drawing.Point(93, 267);
            this.txbMaLichChieu.Name = "txbMaLichChieu";
            this.txbMaLichChieu.ReadOnly = true;
            this.txbMaLichChieu.Size = new System.Drawing.Size(251, 20);
            this.txbMaLichChieu.TabIndex = 7;
            // 
            // txbSoGhe
            // 
            this.txbSoGhe.Location = new System.Drawing.Point(93, 126);
            this.txbSoGhe.Name = "txbSoGhe";
            this.txbSoGhe.Size = new System.Drawing.Size(251, 20);
            this.txbSoGhe.TabIndex = 5;
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(93, 62);
            this.txbMa.Name = "txbMa";
            this.txbMa.ReadOnly = true;
            this.txbMa.Size = new System.Drawing.Size(251, 20);
            this.txbMa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã lịch chiếu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ghế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(190, 50);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(196, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(190, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(196, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(188, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayMua);
            this.groupBox1.Controls.Add(this.txbMaLichChieu);
            this.groupBox1.Controls.Add(this.txbSoGhe);
            this.groupBox1.Controls.Add(this.txbMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(389, 461);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(0, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgrvVe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(389, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 561);
            this.panel1.TabIndex = 3;
            // 
            // dgrvVe
            // 
            this.dgrvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvVe.Location = new System.Drawing.Point(0, 0);
            this.dgrvVe.Name = "dgrvVe";
            this.dgrvVe.Size = new System.Drawing.Size(495, 561);
            this.dgrvVe.TabIndex = 0;
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(93, 201);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(251, 20);
            this.dtpNgayMua.TabIndex = 8;
            // 
            // UcVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcVe";
            this.Size = new System.Drawing.Size(884, 561);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMaLichChieu;
        private System.Windows.Forms.TextBox txbSoGhe;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrvVe;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
    }
}
