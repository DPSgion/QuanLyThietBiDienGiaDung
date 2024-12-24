namespace QuanLyThietBiDienGiaDung
{
    partial class frmQuanLyXuatHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTNguoiMua = new System.Windows.Forms.TextBox();
            this.lblSDTNguoiMua = new System.Windows.Forms.Label();
            this.txtTenNguoiMua = new System.Windows.Forms.TextBox();
            this.lblNguoiMua = new System.Windows.Forms.Label();
            this.txtMaXuatHang = new System.Windows.Forms.TextBox();
            this.lblMaNhapHang = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dgvSPXuatHang = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(861, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 39);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(182, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 37);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Quản lý xuất hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDTNguoiMua);
            this.groupBox1.Controls.Add(this.lblSDTNguoiMua);
            this.groupBox1.Controls.Add(this.txtTenNguoiMua);
            this.groupBox1.Controls.Add(this.lblNguoiMua);
            this.groupBox1.Controls.Add(this.txtMaXuatHang);
            this.groupBox1.Controls.Add(this.lblMaNhapHang);
            this.groupBox1.Controls.Add(this.dtpNgayXuat);
            this.groupBox1.Controls.Add(this.lblNgayNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm xuất hàng";
            // 
            // txtSDTNguoiMua
            // 
            this.txtSDTNguoiMua.Location = new System.Drawing.Point(134, 105);
            this.txtSDTNguoiMua.Name = "txtSDTNguoiMua";
            this.txtSDTNguoiMua.Size = new System.Drawing.Size(174, 20);
            this.txtSDTNguoiMua.TabIndex = 9;
            // 
            // lblSDTNguoiMua
            // 
            this.lblSDTNguoiMua.AutoSize = true;
            this.lblSDTNguoiMua.Location = new System.Drawing.Point(49, 108);
            this.lblSDTNguoiMua.Name = "lblSDTNguoiMua";
            this.lblSDTNguoiMua.Size = new System.Drawing.Size(70, 13);
            this.lblSDTNguoiMua.TabIndex = 8;
            this.lblSDTNguoiMua.Text = "Số điện thoại";
            // 
            // txtTenNguoiMua
            // 
            this.txtTenNguoiMua.Location = new System.Drawing.Point(134, 79);
            this.txtTenNguoiMua.Name = "txtTenNguoiMua";
            this.txtTenNguoiMua.Size = new System.Drawing.Size(174, 20);
            this.txtTenNguoiMua.TabIndex = 7;
            // 
            // lblNguoiMua
            // 
            this.lblNguoiMua.AutoSize = true;
            this.lblNguoiMua.Location = new System.Drawing.Point(49, 82);
            this.lblNguoiMua.Name = "lblNguoiMua";
            this.lblNguoiMua.Size = new System.Drawing.Size(78, 13);
            this.lblNguoiMua.TabIndex = 6;
            this.lblNguoiMua.Text = "Tên người mua";
            // 
            // txtMaXuatHang
            // 
            this.txtMaXuatHang.Location = new System.Drawing.Point(134, 23);
            this.txtMaXuatHang.Name = "txtMaXuatHang";
            this.txtMaXuatHang.Size = new System.Drawing.Size(174, 20);
            this.txtMaXuatHang.TabIndex = 5;
            // 
            // lblMaNhapHang
            // 
            this.lblMaNhapHang.AutoSize = true;
            this.lblMaNhapHang.Location = new System.Drawing.Point(49, 26);
            this.lblMaNhapHang.Name = "lblMaNhapHang";
            this.lblMaNhapHang.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhapHang.TabIndex = 4;
            this.lblMaNhapHang.Text = "Mã xuất hàng";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(134, 49);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(174, 20);
            this.dtpNgayXuat.TabIndex = 3;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(49, 55);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(55, 13);
            this.lblNgayNhap.TabIndex = 2;
            this.lblNgayNhap.Text = "Ngày xuất";
            // 
            // dgvSPXuatHang
            // 
            this.dgvSPXuatHang.AllowUserToAddRows = false;
            this.dgvSPXuatHang.AllowUserToDeleteRows = false;
            this.dgvSPXuatHang.AllowUserToResizeColumns = false;
            this.dgvSPXuatHang.AllowUserToResizeRows = false;
            this.dgvSPXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7});
            this.dgvSPXuatHang.Location = new System.Drawing.Point(562, 64);
            this.dgvSPXuatHang.Name = "dgvSPXuatHang";
            this.dgvSPXuatHang.ReadOnly = true;
            this.dgvSPXuatHang.RowHeadersVisible = false;
            this.dgvSPXuatHang.Size = new System.Drawing.Size(399, 251);
            this.dgvSPXuatHang.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThietBiDienGiaDung.Properties.Resources.right_arrow64px;
            this.pictureBox1.Location = new System.Drawing.Point(492, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.AllowUserToDeleteRows = false;
            this.dgvBanHang.AllowUserToOrderColumns = true;
            this.dgvBanHang.AllowUserToResizeRows = false;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9});
            this.dgvBanHang.Location = new System.Drawing.Point(12, 203);
            this.dgvBanHang.MultiSelect = false;
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.ReadOnly = true;
            this.dgvBanHang.RowHeadersVisible = false;
            this.dgvBanHang.Size = new System.Drawing.Size(464, 165);
            this.dgvBanHang.TabIndex = 18;
            this.dgvBanHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_RowEnter);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaBanHang";
            this.Column4.HeaderText = "Mã";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NguoiMua";
            this.Column5.HeaderText = "Người mua";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "SĐT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayBanHang";
            this.Column8.HeaderText = "Ngày bán";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TongTien";
            this.Column9.HeaderText = "Thành tiền";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 145;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TongTienSP";
            this.Column7.HeaderText = "Tổng tiền SP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frmQuanLyXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 383);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSPXuatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xuất hàng";
            this.Load += new System.EventHandler(this.frmQuanLyXuatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaXuatHang;
        private System.Windows.Forms.Label lblMaNhapHang;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSPXuatHang;
        private System.Windows.Forms.TextBox txtSDTNguoiMua;
        private System.Windows.Forms.Label lblSDTNguoiMua;
        private System.Windows.Forms.TextBox txtTenNguoiMua;
        private System.Windows.Forms.Label lblNguoiMua;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}