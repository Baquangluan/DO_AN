﻿namespace DO_AN.GUI
{
    partial class DUNGCU
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
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Location = new System.Drawing.Point(35, 486);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(188, 486);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Location = new System.Drawing.Point(334, 486);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Location = new System.Drawing.Point(482, 486);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBoqua.Location = new System.Drawing.Point(625, 486);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(102, 34);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDong.Location = new System.Drawing.Point(767, 486);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 34);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvChatLieu.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvChatLieu.Location = new System.Drawing.Point(35, 75);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 51;
            this.dgvChatLieu.RowTemplate.Height = 24;
            this.dgvChatLieu.Size = new System.Drawing.Size(401, 334);
            this.dgvChatLieu.TabIndex = 6;
            this.dgvChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChatLieu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Madungcu";
            this.Column1.HeaderText = "Mã DỤNG Cụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tendungcu";
            this.Column2.HeaderText = "Tên Dụng Cụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(616, 178);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(212, 22);
            this.txtMaChatLieu.TabIndex = 7;
            this.txtMaChatLieu.TextChanged += new System.EventHandler(this.txtMaChatLieu_TextChanged);
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(616, 259);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(212, 22);
            this.txtTenChatLieu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(455, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Dụng Cụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(455, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Dụng Cụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(287, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 38);
            this.label7.TabIndex = 25;
            this.label7.Text = "DANH MỤC DỤNG CỤ";
            // 
            // DUNGCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::DO_AN.Properties.Resources.th__25_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "DUNGCU";
            this.Text = "DANHMUC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}