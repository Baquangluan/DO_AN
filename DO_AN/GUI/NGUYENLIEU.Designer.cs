namespace DO_AN.GUI
{
    partial class NGUYENLIEU
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.btBan = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(448, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 38);
            this.label7.TabIndex = 25;
            this.label7.Text = "DANH MỤC NGUYÊN LIỆU";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvNguyenLieu.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(12, 319);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(1260, 189);
            this.dgvNguyenLieu.TabIndex = 26;
            // 
            // btnThem
            // 
            this.btnThem.AutoEllipsis = true;
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(113, 514);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 34);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoEllipsis = true;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(273, 514);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoEllipsis = true;
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Location = new System.Drawing.Point(435, 514);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 34);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.AutoEllipsis = true;
            this.btnDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Location = new System.Drawing.Point(711, 514);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 34);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoEllipsis = true;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimKiem.Location = new System.Drawing.Point(564, 514);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 34);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.AutoEllipsis = true;
            this.btnInHoaDon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInHoaDon.Location = new System.Drawing.Point(852, 514);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(102, 34);
            this.btnInHoaDon.TabIndex = 34;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(96, 70);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(161, 22);
            this.txtMaHang.TabIndex = 35;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(96, 120);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(161, 22);
            this.txtTenHang.TabIndex = 36;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(393, 120);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(185, 22);
            this.txtDonGiaNhap.TabIndex = 38;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(393, 70);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(185, 22);
            this.txtSoLuong.TabIndex = 39;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(393, 168);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(185, 22);
            this.txtDonGiaBan.TabIndex = 40;
            this.txtDonGiaBan.TextChanged += new System.EventHandler(this.txtDonGiaBan_TextChanged);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(650, 76);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(129, 66);
            this.txtAnh.TabIndex = 41;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(607, 198);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(185, 89);
            this.txtGhiChu.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(4, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mã Chất Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(311, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(284, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Đơn Gía Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(293, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Đơn Gía Bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(604, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ảnh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(604, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ghi Chú";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(881, 70);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(124, 141);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 51;
            this.picAnh.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.Location = new System.Drawing.Point(829, 102);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 34);
            this.btnOpen.TabIndex = 52;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Location = new System.Drawing.Point(96, 166);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(161, 24);
            this.cboMaChatLieu.TabIndex = 53;
            // 
            // btBan
            // 
            this.btBan.AutoEllipsis = true;
            this.btBan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btBan.Location = new System.Drawing.Point(999, 514);
            this.btBan.Name = "btBan";
            this.btBan.Size = new System.Drawing.Size(102, 34);
            this.btBan.TabIndex = 54;
            this.btBan.Text = "Bán";
            this.btBan.UseVisualStyleBackColor = true;
            this.btBan.Click += new System.EventHandler(this.btBan_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nguyên Liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TênNguyên Liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chất Liệu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn Gía Nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn Gía Bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hình";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ghi Chú";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // NGUYENLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DO_AN.Properties.Resources.th__25_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 619);
            this.Controls.Add(this.btBan);
            this.Controls.Add(this.cboMaChatLieu);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNguyenLieu);
            this.Controls.Add(this.label7);
            this.Name = "NGUYENLIEU";
            this.Text = "MATHANG";
            this.Load += new System.EventHandler(this.NGUYENLIEU_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboMaChatLieu;
        private System.Windows.Forms.Button btBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}