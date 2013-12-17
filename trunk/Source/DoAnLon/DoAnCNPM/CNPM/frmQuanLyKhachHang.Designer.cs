namespace CNPM
{
    partial class frmQuanLyKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPhieuThue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxLoaiKhach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnSuaTenKH = new System.Windows.Forms.Button();
            this.btnSuaGioiTinh = new System.Windows.Forms.Button();
            this.btnSuaCMND = new System.Windows.Forms.Button();
            this.btnSuaDiaChi = new System.Windows.Forms.Button();
            this.btnSuaSDT = new System.Windows.Forms.Button();
            this.btnSuaLoaiKhach = new System.Windows.Forms.Button();
            this.btnSuaPhieuThue = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lvwKH = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPhieuThue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxLoaiKhach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.cbxGioiTinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbxPhieuThue
            // 
            this.cbxPhieuThue.FormattingEnabled = true;
            this.cbxPhieuThue.Location = new System.Drawing.Point(257, 308);
            this.cbxPhieuThue.Name = "cbxPhieuThue";
            this.cbxPhieuThue.Size = new System.Drawing.Size(193, 24);
            this.cbxPhieuThue.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phiếu thuê:";
            // 
            // cbxLoaiKhach
            // 
            this.cbxLoaiKhach.FormattingEnabled = true;
            this.cbxLoaiKhach.Items.AddRange(new object[] {
            "Nội Địa",
            "Nước Ngoài"});
            this.cbxLoaiKhach.Location = new System.Drawing.Point(257, 268);
            this.cbxLoaiKhach.Name = "cbxLoaiKhach";
            this.cbxLoaiKhach.Size = new System.Drawing.Size(193, 24);
            this.cbxLoaiKhach.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loại khách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CMND:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(257, 230);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 22);
            this.txtSDT.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(257, 192);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(257, 154);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(193, 22);
            this.txtCMND.TabIndex = 4;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(257, 114);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(193, 24);
            this.cbxGioiTinh.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(257, 76);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(193, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(257, 38);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(193, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // btnSuaTenKH
            // 
            this.btnSuaTenKH.Enabled = false;
            this.btnSuaTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaTenKH.Location = new System.Drawing.Point(593, 88);
            this.btnSuaTenKH.Name = "btnSuaTenKH";
            this.btnSuaTenKH.Size = new System.Drawing.Size(99, 22);
            this.btnSuaTenKH.TabIndex = 9;
            this.btnSuaTenKH.Text = "Chỉnh Sửa";
            this.btnSuaTenKH.UseVisualStyleBackColor = true;
            this.btnSuaTenKH.Click += new System.EventHandler(this.btnSuaTenKH_Click);
            // 
            // btnSuaGioiTinh
            // 
            this.btnSuaGioiTinh.Enabled = false;
            this.btnSuaGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaGioiTinh.Location = new System.Drawing.Point(593, 128);
            this.btnSuaGioiTinh.Name = "btnSuaGioiTinh";
            this.btnSuaGioiTinh.Size = new System.Drawing.Size(99, 22);
            this.btnSuaGioiTinh.TabIndex = 10;
            this.btnSuaGioiTinh.Text = "Chỉnh Sửa";
            this.btnSuaGioiTinh.UseVisualStyleBackColor = true;
            this.btnSuaGioiTinh.Click += new System.EventHandler(this.btnSuaGioiTinh_Click);
            // 
            // btnSuaCMND
            // 
            this.btnSuaCMND.Enabled = false;
            this.btnSuaCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaCMND.Location = new System.Drawing.Point(593, 166);
            this.btnSuaCMND.Name = "btnSuaCMND";
            this.btnSuaCMND.Size = new System.Drawing.Size(99, 22);
            this.btnSuaCMND.TabIndex = 11;
            this.btnSuaCMND.Text = "Chỉnh Sửa";
            this.btnSuaCMND.UseVisualStyleBackColor = true;
            this.btnSuaCMND.Click += new System.EventHandler(this.btnSuaCMND_Click);
            // 
            // btnSuaDiaChi
            // 
            this.btnSuaDiaChi.Enabled = false;
            this.btnSuaDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaDiaChi.Location = new System.Drawing.Point(593, 204);
            this.btnSuaDiaChi.Name = "btnSuaDiaChi";
            this.btnSuaDiaChi.Size = new System.Drawing.Size(99, 22);
            this.btnSuaDiaChi.TabIndex = 12;
            this.btnSuaDiaChi.Text = "Chỉnh Sửa";
            this.btnSuaDiaChi.UseVisualStyleBackColor = true;
            this.btnSuaDiaChi.Click += new System.EventHandler(this.btnSuaDiaChi_Click);
            // 
            // btnSuaSDT
            // 
            this.btnSuaSDT.Enabled = false;
            this.btnSuaSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaSDT.Location = new System.Drawing.Point(593, 242);
            this.btnSuaSDT.Name = "btnSuaSDT";
            this.btnSuaSDT.Size = new System.Drawing.Size(99, 22);
            this.btnSuaSDT.TabIndex = 13;
            this.btnSuaSDT.Text = "Chỉnh Sửa";
            this.btnSuaSDT.UseVisualStyleBackColor = true;
            this.btnSuaSDT.Click += new System.EventHandler(this.btnSuaSDT_Click);
            // 
            // btnSuaLoaiKhach
            // 
            this.btnSuaLoaiKhach.Enabled = false;
            this.btnSuaLoaiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiKhach.Location = new System.Drawing.Point(593, 282);
            this.btnSuaLoaiKhach.Name = "btnSuaLoaiKhach";
            this.btnSuaLoaiKhach.Size = new System.Drawing.Size(99, 22);
            this.btnSuaLoaiKhach.TabIndex = 14;
            this.btnSuaLoaiKhach.Text = "Chỉnh Sửa";
            this.btnSuaLoaiKhach.UseVisualStyleBackColor = true;
            this.btnSuaLoaiKhach.Click += new System.EventHandler(this.btnSuaLoaiKhach_Click);
            // 
            // btnSuaPhieuThue
            // 
            this.btnSuaPhieuThue.Enabled = false;
            this.btnSuaPhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhieuThue.Location = new System.Drawing.Point(593, 320);
            this.btnSuaPhieuThue.Name = "btnSuaPhieuThue";
            this.btnSuaPhieuThue.Size = new System.Drawing.Size(99, 22);
            this.btnSuaPhieuThue.TabIndex = 15;
            this.btnSuaPhieuThue.Text = "Chỉnh Sửa";
            this.btnSuaPhieuThue.UseVisualStyleBackColor = true;
            this.btnSuaPhieuThue.Click += new System.EventHandler(this.btnSuaPhieuThue_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(81, 479);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 22);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(236, 479);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 22);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(544, 479);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 22);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(389, 479);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 22);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lvwKH
            // 
            this.lvwKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwKH.FullRowSelect = true;
            this.lvwKH.GridLines = true;
            this.lvwKH.Location = new System.Drawing.Point(11, 380);
            this.lvwKH.Name = "lvwKH";
            this.lvwKH.Size = new System.Drawing.Size(704, 84);
            this.lvwKH.TabIndex = 20;
            this.lvwKH.UseCompatibleStateImageBehavior = false;
            this.lvwKH.View = System.Windows.Forms.View.Details;
            this.lvwKH.SelectedIndexChanged += new System.EventHandler(this.lvwKH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khách Hàng";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới Tính";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CMND";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Điện Thoại";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã Loại Khách";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Phiếu Thuê";
            this.columnHeader8.Width = 90;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 518);
            this.Controls.Add(this.lvwKH);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSuaPhieuThue);
            this.Controls.Add(this.btnSuaLoaiKhach);
            this.Controls.Add(this.btnSuaSDT);
            this.Controls.Add(this.btnSuaDiaChi);
            this.Controls.Add(this.btnSuaCMND);
            this.Controls.Add(this.btnSuaGioiTinh);
            this.Controls.Add(this.btnSuaTenKH);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ComboBox cbxPhieuThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxLoaiKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSuaTenKH;
        private System.Windows.Forms.Button btnSuaGioiTinh;
        private System.Windows.Forms.Button btnSuaCMND;
        private System.Windows.Forms.Button btnSuaDiaChi;
        private System.Windows.Forms.Button btnSuaSDT;
        private System.Windows.Forms.Button btnSuaLoaiKhach;
        private System.Windows.Forms.Button btnSuaPhieuThue;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView lvwKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}