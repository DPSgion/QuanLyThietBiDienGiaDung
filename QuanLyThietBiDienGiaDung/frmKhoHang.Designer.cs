namespace QuanLyThietBiDienGiaDung
{
    partial class frmKhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdoTimGia = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.groCapNhatGia = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtGiaMoi = new System.Windows.Forms.TextBox();
            this.lblNhapGiaMoi = new System.Windows.Forms.Label();
            this.cboSuaGiaSP = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.groTimKiem = new System.Windows.Forms.GroupBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblTheoHang = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.cboTheoHang = new System.Windows.Forms.ComboBox();
            this.cboTimMaSP = new System.Windows.Forms.ComboBox();
            this.rdoTimTenSP = new System.Windows.Forms.RadioButton();
            this.cboTimGiaSP = new System.Windows.Forms.ComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.groCapNhatGia.SuspendLayout();
            this.groTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHang.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column8,
            this.Column9,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHang.GridColor = System.Drawing.Color.Black;
            this.dgvHang.Location = new System.Drawing.Point(12, 57);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersVisible = false;
            this.dgvHang.Size = new System.Drawing.Size(776, 345);
            this.dgvHang.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(93, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(613, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DANH SÁCH SẢN PHẨM TRONG CỬA HÀNG";
            // 
            // rdoTimGia
            // 
            this.rdoTimGia.AutoSize = true;
            this.rdoTimGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTimGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.rdoTimGia.Location = new System.Drawing.Point(15, 64);
            this.rdoTimGia.Name = "rdoTimGia";
            this.rdoTimGia.Size = new System.Drawing.Size(95, 17);
            this.rdoTimGia.TabIndex = 7;
            this.rdoTimGia.Text = "Tìm theo giá";
            this.rdoTimGia.UseVisualStyleBackColor = true;
            this.rdoTimGia.CheckedChanged += new System.EventHandler(this.rdoTimGia_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnSuaSP);
            this.panel1.Controls.Add(this.groCapNhatGia);
            this.panel1.Controls.Add(this.groTimKiem);
            this.panel1.Location = new System.Drawing.Point(12, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 179);
            this.panel1.TabIndex = 8;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Image = global::QuanLyThietBiDienGiaDung.Properties.Resources.recycle_bin;
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(638, 129);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(129, 41);
            this.btnXoaSP.TabIndex = 20;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.MouseEnter += new System.EventHandler(this.btnXoaSP_MouseEnter);
            this.btnXoaSP.MouseLeave += new System.EventHandler(this.btnXoaSP_MouseLeave);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Image = global::QuanLyThietBiDienGiaDung.Properties.Resources.settings;
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(503, 129);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(129, 41);
            this.btnSuaSP.TabIndex = 19;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // groCapNhatGia
            // 
            this.groCapNhatGia.Controls.Add(this.btnCapNhat);
            this.groCapNhatGia.Controls.Add(this.txtMaSP);
            this.groCapNhatGia.Controls.Add(this.lblMaSP);
            this.groCapNhatGia.Controls.Add(this.txtGiaMoi);
            this.groCapNhatGia.Controls.Add(this.lblNhapGiaMoi);
            this.groCapNhatGia.Controls.Add(this.cboSuaGiaSP);
            this.groCapNhatGia.Controls.Add(this.lblTenSP);
            this.groCapNhatGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groCapNhatGia.Location = new System.Drawing.Point(359, 13);
            this.groCapNhatGia.Name = "groCapNhatGia";
            this.groCapNhatGia.Size = new System.Drawing.Size(408, 102);
            this.groCapNhatGia.TabIndex = 18;
            this.groCapNhatGia.TabStop = false;
            this.groCapNhatGia.Text = "🔧 Cập nhật giá";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(296, 58);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(326, 23);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(73, 22);
            this.txtMaSP.TabIndex = 17;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(276, 28);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(47, 16);
            this.lblMaSP.TabIndex = 16;
            this.lblMaSP.Text = "Mã SP";
            // 
            // txtGiaMoi
            // 
            this.txtGiaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMoi.Location = new System.Drawing.Point(99, 59);
            this.txtGiaMoi.Name = "txtGiaMoi";
            this.txtGiaMoi.Size = new System.Drawing.Size(166, 22);
            this.txtGiaMoi.TabIndex = 15;
            // 
            // lblNhapGiaMoi
            // 
            this.lblNhapGiaMoi.AutoSize = true;
            this.lblNhapGiaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapGiaMoi.Location = new System.Drawing.Point(6, 66);
            this.lblNhapGiaMoi.Name = "lblNhapGiaMoi";
            this.lblNhapGiaMoi.Size = new System.Drawing.Size(81, 13);
            this.lblNhapGiaMoi.TabIndex = 14;
            this.lblNhapGiaMoi.Text = "Nhập giá mới";
            // 
            // cboSuaGiaSP
            // 
            this.cboSuaGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuaGiaSP.ForeColor = System.Drawing.Color.Silver;
            this.cboSuaGiaSP.FormattingEnabled = true;
            this.cboSuaGiaSP.Location = new System.Drawing.Point(99, 21);
            this.cboSuaGiaSP.Name = "cboSuaGiaSP";
            this.cboSuaGiaSP.Size = new System.Drawing.Size(166, 24);
            this.cboSuaGiaSP.TabIndex = 12;
            this.cboSuaGiaSP.Text = "Nhập tên sản phẩm";
            this.cboSuaGiaSP.Enter += new System.EventHandler(this.cboSuaGiaSP_Enter);
            this.cboSuaGiaSP.Leave += new System.EventHandler(this.cboSuaGiaSP_Leave);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(6, 32);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(87, 13);
            this.lblTenSP.TabIndex = 13;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // groTimKiem
            // 
            this.groTimKiem.Controls.Add(this.lblLoaiHang);
            this.groTimKiem.Controls.Add(this.lblTheoHang);
            this.groTimKiem.Controls.Add(this.cboLoaiHang);
            this.groTimKiem.Controls.Add(this.cboTheoHang);
            this.groTimKiem.Controls.Add(this.cboTimMaSP);
            this.groTimKiem.Controls.Add(this.rdoTimTenSP);
            this.groTimKiem.Controls.Add(this.cboTimGiaSP);
            this.groTimKiem.Controls.Add(this.rdoTimGia);
            this.groTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groTimKiem.Location = new System.Drawing.Point(15, 13);
            this.groTimKiem.Name = "groTimKiem";
            this.groTimKiem.Size = new System.Drawing.Size(333, 163);
            this.groTimKiem.TabIndex = 12;
            this.groTimKiem.TabStop = false;
            this.groTimKiem.Text = "🔍 Tìm kiếm";
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiHang.Location = new System.Drawing.Point(87, 130);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(63, 13);
            this.lblLoaiHang.TabIndex = 17;
            this.lblLoaiHang.Text = "Loại hàng";
            // 
            // lblTheoHang
            // 
            this.lblTheoHang.AutoSize = true;
            this.lblTheoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheoHang.ForeColor = System.Drawing.Color.Black;
            this.lblTheoHang.Location = new System.Drawing.Point(82, 103);
            this.lblTheoHang.Name = "lblTheoHang";
            this.lblTheoHang.Size = new System.Drawing.Size(68, 13);
            this.lblTheoHang.TabIndex = 16;
            this.lblTheoHang.Text = "Theo hãng";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(170, 122);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(150, 24);
            this.cboLoaiHang.TabIndex = 15;
            // 
            // cboTheoHang
            // 
            this.cboTheoHang.FormattingEnabled = true;
            this.cboTheoHang.Location = new System.Drawing.Point(170, 92);
            this.cboTheoHang.Name = "cboTheoHang";
            this.cboTheoHang.Size = new System.Drawing.Size(150, 24);
            this.cboTheoHang.TabIndex = 13;
            // 
            // cboTimMaSP
            // 
            this.cboTimMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimMaSP.ForeColor = System.Drawing.Color.Silver;
            this.cboTimMaSP.FormattingEnabled = true;
            this.cboTimMaSP.Location = new System.Drawing.Point(126, 21);
            this.cboTimMaSP.Name = "cboTimMaSP";
            this.cboTimMaSP.Size = new System.Drawing.Size(195, 24);
            this.cboTimMaSP.TabIndex = 11;
            this.cboTimMaSP.Text = "Nhập tên sản phẩm";
            this.cboTimMaSP.Enter += new System.EventHandler(this.cboTimMaSP_Enter);
            this.cboTimMaSP.Leave += new System.EventHandler(this.cboTimMaSP_Leave);
            // 
            // rdoTimTenSP
            // 
            this.rdoTimTenSP.AutoSize = true;
            this.rdoTimTenSP.Checked = true;
            this.rdoTimTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTimTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoTimTenSP.Location = new System.Drawing.Point(15, 28);
            this.rdoTimTenSP.Name = "rdoTimTenSP";
            this.rdoTimTenSP.Size = new System.Drawing.Size(105, 17);
            this.rdoTimTenSP.TabIndex = 10;
            this.rdoTimTenSP.TabStop = true;
            this.rdoTimTenSP.Text = "Tên sản phẩm";
            this.rdoTimTenSP.UseVisualStyleBackColor = true;
            this.rdoTimTenSP.CheckedChanged += new System.EventHandler(this.rdoTimTenSP_CheckedChanged);
            // 
            // cboTimGiaSP
            // 
            this.cboTimGiaSP.Enabled = false;
            this.cboTimGiaSP.FormattingEnabled = true;
            this.cboTimGiaSP.Location = new System.Drawing.Point(126, 57);
            this.cboTimGiaSP.Name = "cboTimGiaSP";
            this.cboTimGiaSP.Size = new System.Drawing.Size(195, 24);
            this.cboTimGiaSP.TabIndex = 9;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.Name = "Column4";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "SL";
            this.Column9.Name = "Column9";
            this.Column9.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hạn bảo hành";
            this.Column8.Name = "Column8";
            this.Column8.Width = 98;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thông số kĩ thuật";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã NCC";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thương hiệu";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên mặt hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groCapNhatGia.ResumeLayout(false);
            this.groCapNhatGia.PerformLayout();
            this.groTimKiem.ResumeLayout(false);
            this.groTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdoTimGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTimGiaSP;
        private System.Windows.Forms.RadioButton rdoTimTenSP;
        private System.Windows.Forms.GroupBox groTimKiem;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.ComboBox cboTimMaSP;
        private System.Windows.Forms.ComboBox cboSuaGiaSP;
        private System.Windows.Forms.Label lblNhapGiaMoi;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtGiaMoi;
        private System.Windows.Forms.ComboBox cboTheoHang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblTheoHang;
        private System.Windows.Forms.GroupBox groCapNhatGia;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}