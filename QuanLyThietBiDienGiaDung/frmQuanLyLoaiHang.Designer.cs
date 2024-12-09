namespace QuanLyThietBiDienGiaDung
{
    partial class frmQuanLyLoaiHang
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
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnXoaLH = new System.Windows.Forms.Button();
            this.lblTenLH = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaLH = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLH
            // 
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLH.Location = new System.Drawing.Point(27, 53);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.RowHeadersVisible = false;
            this.dgvLH.Size = new System.Drawing.Size(354, 202);
            this.dgvLH.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã LH";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên loại hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng sản phẩm";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(102, 261);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(91, 38);
            this.btnThemLH.TabIndex = 1;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = true;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnXoaLH
            // 
            this.btnXoaLH.Location = new System.Drawing.Point(290, 261);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(91, 38);
            this.btnXoaLH.TabIndex = 2;
            this.btnXoaLH.Text = "Xóa";
            this.btnXoaLH.UseVisualStyleBackColor = true;
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            // 
            // lblTenLH
            // 
            this.lblTenLH.AutoSize = true;
            this.lblTenLH.Location = new System.Drawing.Point(39, 30);
            this.lblTenLH.Name = "lblTenLH";
            this.lblTenLH.Size = new System.Drawing.Size(72, 13);
            this.lblTenLH.TabIndex = 3;
            this.lblTenLH.Text = "Tên loại hàng";
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(126, 27);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(161, 20);
            this.txtTenLH.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(306, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 20);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaLH);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTenLH);
            this.groupBox1.Controls.Add(this.lblTenLH);
            this.groupBox1.Controls.Add(this.btnXoaLH);
            this.groupBox1.Controls.Add(this.btnThemLH);
            this.groupBox1.Controls.Add(this.dgvLH);
            this.groupBox1.Location = new System.Drawing.Point(22, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin các loại hàng";
            // 
            // btnSuaLH
            // 
            this.btnSuaLH.Location = new System.Drawing.Point(196, 261);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(91, 38);
            this.btnSuaLH.TabIndex = 6;
            this.btnSuaLH.Text = "Sửa";
            this.btnSuaLH.UseVisualStyleBackColor = true;
            this.btnSuaLH.Click += new System.EventHandler(this.btnSuaLH_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(104, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 31);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Quản lý loại hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(336, 367);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnXoaLH;
        private System.Windows.Forms.Label lblTenLH;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaLH;
    }
}