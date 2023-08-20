namespace DO_AN.GUI
{
    partial class NHANVIEN
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(35, 471);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(167, 471);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Location = new System.Drawing.Point(307, 471);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 34);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Location = new System.Drawing.Point(455, 471);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 34);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBoqua.Location = new System.Drawing.Point(601, 471);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(102, 34);
            this.btnBoqua.TabIndex = 10;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Location = new System.Drawing.Point(737, 471);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 34);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(151, 87);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(185, 22);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(151, 115);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(185, 22);
            this.txtTenNhanVien.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(151, 149);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 22);
            this.txtDiaChi.TabIndex = 14;
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(572, 93);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(156, 22);
            this.mtbDienThoai.TabIndex = 16;
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(572, 121);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(156, 22);
            this.mskNgaySinh.TabIndex = 17;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(45, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(470, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số Liện Lạc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(470, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(332, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 38);
            this.label7.TabIndex = 24;
            this.label7.Text = "DANH MỤC NHÂN VIÊN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(470, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Gioi Tính";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(572, 158);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(58, 20);
            this.chkGioiTinh.TabIndex = 26;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToOrderColumns = true;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhanVien.Location = new System.Drawing.Point(17, 197);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1058, 268);
            this.dgvNhanVien.TabIndex = 7;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhanVien";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNhanVien";
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Số Liên Lạc";
            this.Column5.HeaderText = "Số Liên Lạc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgaySinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 125;
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DO_AN.Properties.Resources.th__24_;
            this.ClientSize = new System.Drawing.Size(1140, 546);
            this.Controls.Add(this.chkGioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskNgaySinh);
            this.Controls.Add(this.mtbDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NHANVIEN";
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.NHANVIEN_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}