﻿namespace QuanLyThietBiDienGiaDung
{
    partial class frmNhapHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKhongThayTenSP = new System.Windows.Forms.Label();
            this.lblKhongTimThayMaSP = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaNhapHang = new System.Windows.Forms.Label();
            this.txtMaNhapHang = new System.Windows.Forms.TextBox();
            this.btnTaoMaNhapHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(143, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Nhập hàng";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(44, 54);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(75, 13);
            this.lblTenSP.TabIndex = 2;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(121, 51);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(129, 20);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenSP_KeyDown);
            this.txtTenSP.Leave += new System.EventHandler(this.txtTenSP_Leave);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(121, 25);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(129, 20);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSP_KeyDown);
            this.txtMaSP.Leave += new System.EventHandler(this.txtMaSP_Leave);
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(44, 28);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(71, 13);
            this.lblMaSP.TabIndex = 4;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(121, 76);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(44, 79);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNhapHang.Location = new System.Drawing.Point(30, 102);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersVisible = false;
            this.dgvNhapHang.Size = new System.Drawing.Size(316, 165);
            this.dgvNhapHang.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(261, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 20);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(80, 431);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 49);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(244, 431);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 49);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKhongThayTenSP);
            this.groupBox1.Controls.Add(this.lblKhongTimThayMaSP);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dgvNhapHang);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lblMaSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.lblTenSP);
            this.groupBox1.Location = new System.Drawing.Point(34, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập hàng";
            // 
            // lblKhongThayTenSP
            // 
            this.lblKhongThayTenSP.AutoSize = true;
            this.lblKhongThayTenSP.ForeColor = System.Drawing.Color.Red;
            this.lblKhongThayTenSP.Location = new System.Drawing.Point(256, 54);
            this.lblKhongThayTenSP.Name = "lblKhongThayTenSP";
            this.lblKhongThayTenSP.Size = new System.Drawing.Size(101, 13);
            this.lblKhongThayTenSP.TabIndex = 18;
            this.lblKhongThayTenSP.Text = "Không đúng tên SP";
            this.lblKhongThayTenSP.Visible = false;
            // 
            // lblKhongTimThayMaSP
            // 
            this.lblKhongTimThayMaSP.AutoSize = true;
            this.lblKhongTimThayMaSP.ForeColor = System.Drawing.Color.Red;
            this.lblKhongTimThayMaSP.Location = new System.Drawing.Point(256, 28);
            this.lblKhongTimThayMaSP.Name = "lblKhongTimThayMaSP";
            this.lblKhongTimThayMaSP.Size = new System.Drawing.Size(100, 13);
            this.lblKhongTimThayMaSP.TabIndex = 17;
            this.lblKhongTimThayMaSP.Text = "Không đúng mã SP";
            this.lblKhongTimThayMaSP.Visible = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(121, 277);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(145, 20);
            this.txtTongTien.TabIndex = 16;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(63, 284);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(52, 13);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(130, 79);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày nhập";
            // 
            // lblMaNhapHang
            // 
            this.lblMaNhapHang.AutoSize = true;
            this.lblMaNhapHang.Location = new System.Drawing.Point(48, 56);
            this.lblMaNhapHang.Name = "lblMaNhapHang";
            this.lblMaNhapHang.Size = new System.Drawing.Size(76, 13);
            this.lblMaNhapHang.TabIndex = 13;
            this.lblMaNhapHang.Text = "Mã nhập hàng";
            // 
            // txtMaNhapHang
            // 
            this.txtMaNhapHang.Location = new System.Drawing.Point(130, 53);
            this.txtMaNhapHang.Name = "txtMaNhapHang";
            this.txtMaNhapHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhapHang.TabIndex = 0;
            // 
            // btnTaoMaNhapHang
            // 
            this.btnTaoMaNhapHang.Location = new System.Drawing.Point(236, 49);
            this.btnTaoMaNhapHang.Name = "btnTaoMaNhapHang";
            this.btnTaoMaNhapHang.Size = new System.Drawing.Size(93, 24);
            this.btnTaoMaNhapHang.TabIndex = 17;
            this.btnTaoMaNhapHang.Text = "Tạo mã nhanh";
            this.btnTaoMaNhapHang.UseVisualStyleBackColor = true;
            this.btnTaoMaNhapHang.Click += new System.EventHandler(this.btnTaoMaNhapHang_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 498);
            this.Controls.Add(this.btnTaoMaNhapHang);
            this.Controls.Add(this.txtMaNhapHang);
            this.Controls.Add(this.lblMaNhapHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaNhapHang;
        private System.Windows.Forms.TextBox txtMaNhapHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTaoMaNhapHang;
        private System.Windows.Forms.Label lblKhongTimThayMaSP;
        private System.Windows.Forms.Label lblKhongThayTenSP;
    }
}