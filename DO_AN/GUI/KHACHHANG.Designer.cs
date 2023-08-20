namespace DO_AN.GUI
{
    partial class KHACHHANG
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.btnThemm = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 233);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(845, 268);
            this.dgvKhachHang.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhach";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhach";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Điện Thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(142, 95);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(185, 22);
            this.txtMaKhach.TabIndex = 13;
            this.txtMaKhach.TextChanged += new System.EventHandler(this.txtMaKhach_TextChanged);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(142, 144);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(185, 22);
            this.txtTenKhach.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(574, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 22);
            this.txtDiaChi.TabIndex = 15;
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(574, 144);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(185, 22);
            this.mtbDienThoai.TabIndex = 17;
            // 
            // btnThemm
            // 
            this.btnThemm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemm.Location = new System.Drawing.Point(12, 529);
            this.btnThemm.Name = "btnThemm";
            this.btnThemm.Size = new System.Drawing.Size(102, 34);
            this.btnThemm.TabIndex = 19;
            this.btnThemm.Text = "Thêm";
            this.btnThemm.UseVisualStyleBackColor = true;
            this.btnThemm.Click += new System.EventHandler(this.btnThemm_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(151, 529);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Location = new System.Drawing.Point(295, 529);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 34);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Location = new System.Drawing.Point(430, 529);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 34);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBoqua.Location = new System.Drawing.Point(574, 529);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(102, 34);
            this.btnBoqua.TabIndex = 23;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Location = new System.Drawing.Point(716, 529);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 34);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(483, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(483, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số Liên Lạc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(228, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 38);
            this.label7.TabIndex = 29;
            this.label7.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DO_AN.Properties.Resources.th__25_;
            this.ClientSize = new System.Drawing.Size(874, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemm);
            this.Controls.Add(this.mtbDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "KHACHHANG";
            this.Text = "KHACHHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.Button btnThemm;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}