namespace QuanLyThietBiDienGiaDung
{
    partial class frmThemMatHangMoi
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
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.lblHang = new System.Windows.Forms.Label();
            this.txtTSKT = new System.Windows.Forms.TextBox();
            this.lblTSKT = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Thêm sản phẩm mới";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(24, 24);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(39, 13);
            this.lblMaSP.TabIndex = 4;
            this.lblMaSP.Text = "Mã SP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(105, 21);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 20);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(105, 47);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(131, 20);
            this.txtTenSP.TabIndex = 7;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(24, 50);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(75, 13);
            this.lblTenSanPham.TabIndex = 6;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(105, 99);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(100, 20);
            this.txtHang.TabIndex = 9;
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(24, 102);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(33, 13);
            this.lblHang.TabIndex = 8;
            this.lblHang.Text = "Hãng";
            // 
            // txtTSKT
            // 
            this.txtTSKT.Location = new System.Drawing.Point(123, 125);
            this.txtTSKT.Multiline = true;
            this.txtTSKT.Name = "txtTSKT";
            this.txtTSKT.Size = new System.Drawing.Size(177, 68);
            this.txtTSKT.TabIndex = 11;
            // 
            // lblTSKT
            // 
            this.lblTSKT.AutoSize = true;
            this.lblTSKT.Location = new System.Drawing.Point(24, 140);
            this.lblTSKT.Name = "lblTSKT";
            this.lblTSKT.Size = new System.Drawing.Size(93, 13);
            this.lblTSKT.TabIndex = 10;
            this.lblTSKT.Text = "Thông số kĩ thuật";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(105, 225);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 15;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(24, 228);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(44, 13);
            this.lblGiaBan.TabIndex = 14;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(73, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(202, 347);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 42);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboLoaiHang);
            this.groupBox1.Controls.Add(this.lblLoaiHang);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.lblGiaBan);
            this.groupBox1.Controls.Add(this.txtTSKT);
            this.groupBox1.Controls.Add(this.lblTSKT);
            this.groupBox1.Controls.Add(this.txtHang);
            this.groupBox1.Controls.Add(this.lblHang);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.lblTenSanPham);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lblMaSP);
            this.groupBox1.Location = new System.Drawing.Point(37, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 281);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm mới";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(105, 199);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtGiaNhap.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giá nhập";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(105, 73);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(131, 21);
            this.cboLoaiHang.TabIndex = 17;
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Location = new System.Drawing.Point(24, 76);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(54, 13);
            this.lblLoaiHang.TabIndex = 16;
            this.lblLoaiHang.Text = "Loại hàng";
            // 
            // frmThemMatHangMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemMatHangMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mặt hàng mới";
            this.Load += new System.EventHandler(this.frmThemMatHangMoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.TextBox txtTSKT;
        private System.Windows.Forms.Label lblTSKT;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label1;
    }
}