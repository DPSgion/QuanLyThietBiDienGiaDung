namespace QuanLyThietBiDienGiaDung
{
    partial class frmThemLoaiHang
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
            this.lblMaLH = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.lblTenLH = new System.Windows.Forms.Label();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Location = new System.Drawing.Point(35, 83);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(68, 13);
            this.lblMaLH.TabIndex = 0;
            this.lblMaLH.Text = "Mã loại hàng";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(109, 80);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(156, 20);
            this.txtMaLH.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Thêm loại hàng mới";
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(109, 106);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(156, 20);
            this.txtTenLH.TabIndex = 4;
            // 
            // lblTenLH
            // 
            this.lblTenLH.AutoSize = true;
            this.lblTenLH.Location = new System.Drawing.Point(35, 109);
            this.lblTenLH.Name = "lblTenLH";
            this.lblTenLH.Size = new System.Drawing.Size(72, 13);
            this.lblTenLH.TabIndex = 3;
            this.lblTenLH.Text = "Tên loại hàng";
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(48, 152);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(87, 38);
            this.btnThemLH.TabIndex = 5;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(160, 152);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 38);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 215);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemLH);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.lblTenLH);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.lblMaLH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label lblTenLH;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnHuy;
    }
}