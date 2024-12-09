namespace QuanLyThietBiDienGiaDung
{
    partial class frmSuaLoaiHang
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaLH = new System.Windows.Forms.Button();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.lblTenLH = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(163, 154);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 38);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaLH
            // 
            this.btnSuaLH.Location = new System.Drawing.Point(52, 154);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(87, 38);
            this.btnSuaLH.TabIndex = 12;
            this.btnSuaLH.Text = "Sửa";
            this.btnSuaLH.UseVisualStyleBackColor = true;
            this.btnSuaLH.Click += new System.EventHandler(this.btnSuaLH_Click);
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(103, 105);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(156, 20);
            this.txtTenLH.TabIndex = 11;
            // 
            // lblTenLH
            // 
            this.lblTenLH.AutoSize = true;
            this.lblTenLH.Location = new System.Drawing.Point(29, 108);
            this.lblTenLH.Name = "lblTenLH";
            this.lblTenLH.Size = new System.Drawing.Size(72, 13);
            this.lblTenLH.TabIndex = 10;
            this.lblTenLH.Text = "Tên loại hàng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Sửa loại hàng";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(103, 79);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(156, 20);
            this.txtMaLH.TabIndex = 8;
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Location = new System.Drawing.Point(29, 82);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(68, 13);
            this.lblMaLH.TabIndex = 7;
            this.lblMaLH.Text = "Mã loại hàng";
            // 
            // frmSuaLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 229);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSuaLH);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.lblTenLH);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.lblMaLH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa loại hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSuaLH;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label lblTenLH;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label lblMaLH;
    }
}