namespace QuanLyThietBiDienGiaDung
{
    partial class frmQuanLyNhapHang
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
            this.dgvSPNhapHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblMaNhapHang = new System.Windows.Forms.Label();
            this.txtMaNhapHang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNgayNhap = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSPNhapHang
            // 
            this.dgvSPNhapHang.AutoGenerateColumns = false;
            this.dgvSPNhapHang.AllowUserToAddRows = false;
            this.dgvSPNhapHang.AllowUserToDeleteRows = false;
            this.dgvSPNhapHang.AllowUserToResizeColumns = false;
            this.dgvSPNhapHang.AllowUserToResizeRows = false;
            this.dgvSPNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSPNhapHang.Location = new System.Drawing.Point(415, 92);
            this.dgvSPNhapHang.Name = "dgvSPNhapHang";
            this.dgvSPNhapHang.ReadOnly = true;
            this.dgvSPNhapHang.RowHeadersVisible = false;
            this.dgvSPNhapHang.Size = new System.Drawing.Size(319, 266);
            this.dgvSPNhapHang.TabIndex = 0;
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
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.AllowUserToResizeColumns = false;
            this.dgvNhapHang.AllowUserToResizeRows = false;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhapHang.Location = new System.Drawing.Point(12, 203);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.RowHeadersVisible = false;
            this.dgvNhapHang.Size = new System.Drawing.Size(319, 155);
            this.dgvNhapHang.TabIndex = 1;
            this.dgvNhapHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_RowEnter);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNhapHang";
            this.Column4.HeaderText = "Mã nhập hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayNhapHang";
            this.Column5.HeaderText = "Ngày nhập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongTienNhapHang";
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(100, 49);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(146, 20);
            this.dtpNgayNhap.TabIndex = 3;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // lblMaNhapHang
            // 
            this.lblMaNhapHang.AutoSize = true;
            this.lblMaNhapHang.Location = new System.Drawing.Point(15, 22);
            this.lblMaNhapHang.Name = "lblMaNhapHang";
            this.lblMaNhapHang.Size = new System.Drawing.Size(76, 13);
            this.lblMaNhapHang.TabIndex = 4;
            this.lblMaNhapHang.Text = "Mã nhập hàng";
            // 
            // txtMaNhapHang
            // 
            this.txtMaNhapHang.Location = new System.Drawing.Point(100, 19);
            this.txtMaNhapHang.Name = "txtMaNhapHang";
            this.txtMaNhapHang.Size = new System.Drawing.Size(146, 20);
            this.txtMaNhapHang.TabIndex = 5;
            this.txtMaNhapHang.TextChanged += new System.EventHandler(this.txtMaNhapHang_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNgayNhap);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtMaNhapHang);
            this.groupBox1.Controls.Add(this.lblMaNhapHang);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhập hàng";
            // 
            // cboNgayNhap
            // 
            this.cboNgayNhap.AutoSize = true;
            this.cboNgayNhap.Location = new System.Drawing.Point(18, 52);
            this.cboNgayNhap.Name = "cboNgayNhap";
            this.cboNgayNhap.Size = new System.Drawing.Size(78, 17);
            this.cboNgayNhap.TabIndex = 12;
            this.cboNgayNhap.Text = "Ngày nhập";
            this.cboNgayNhap.UseVisualStyleBackColor = true;
            this.cboNgayNhap.CheckedChanged += new System.EventHandler(this.cboNgayNhap_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 79);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 24);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 31);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Quản lý nhập hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyThietBiDienGiaDung.Properties.Resources.shipped64px;
            this.pictureBox2.Location = new System.Drawing.Point(482, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThietBiDienGiaDung.Properties.Resources.right_arrow64px;
            this.pictureBox1.Location = new System.Drawing.Point(337, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(634, 373);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 424);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhapHang);
            this.Controls.Add(this.dgvSPNhapHang);
            this.Name = "frmQuanLyNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.frmQuanLyNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSPNhapHang;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblMaNhapHang;
        private System.Windows.Forms.TextBox txtMaNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cboNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}