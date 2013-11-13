namespace CNPM
{
    partial class frmQuanLyNhanVien
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
            this.dgrvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChinhSua5 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnChinhSua4 = new System.Windows.Forms.Button();
            this.btnChinhSua3 = new System.Windows.Forms.Button();
            this.btnChinhSua2 = new System.Windows.Forms.Button();
            this.btnChinhSua1 = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvDanhSach
            // 
            this.dgrvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clHoTen,
            this.clChucVu,
            this.clDiaChi,
            this.clSDT,
            this.clEmail});
            this.dgrvDanhSach.Location = new System.Drawing.Point(26, 323);
            this.dgrvDanhSach.Name = "dgrvDanhSach";
            this.dgrvDanhSach.Size = new System.Drawing.Size(639, 73);
            this.dgrvDanhSach.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // clHoTen
            // 
            this.clHoTen.HeaderText = "Họ tên nhân viên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.Width = 120;
            // 
            // clChucVu
            // 
            this.clChucVu.HeaderText = "Chức vụ";
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 75;
            // 
            // clDiaChi
            // 
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            // 
            // clSDT
            // 
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChinhSua5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.btnChinhSua4);
            this.groupBox1.Controls.Add(this.btnChinhSua3);
            this.groupBox1.Controls.Add(this.btnChinhSua2);
            this.groupBox1.Controls.Add(this.btnChinhSua1);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.lblSoDienThoai);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 261);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnChinhSua5
            // 
            this.btnChinhSua5.Location = new System.Drawing.Point(481, 202);
            this.btnChinhSua5.Name = "btnChinhSua5";
            this.btnChinhSua5.Size = new System.Drawing.Size(91, 23);
            this.btnChinhSua5.TabIndex = 7;
            this.btnChinhSua5.Text = "Chỉnh sửa";
            this.btnChinhSua5.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(203, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(60, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // btnChinhSua4
            // 
            this.btnChinhSua4.Location = new System.Drawing.Point(481, 158);
            this.btnChinhSua4.Name = "btnChinhSua4";
            this.btnChinhSua4.Size = new System.Drawing.Size(91, 23);
            this.btnChinhSua4.TabIndex = 6;
            this.btnChinhSua4.Text = "Chỉnh sửa";
            this.btnChinhSua4.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua3
            // 
            this.btnChinhSua3.Location = new System.Drawing.Point(481, 117);
            this.btnChinhSua3.Name = "btnChinhSua3";
            this.btnChinhSua3.Size = new System.Drawing.Size(91, 23);
            this.btnChinhSua3.TabIndex = 5;
            this.btnChinhSua3.Text = "Chỉnh sửa";
            this.btnChinhSua3.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua2
            // 
            this.btnChinhSua2.Location = new System.Drawing.Point(481, 76);
            this.btnChinhSua2.Name = "btnChinhSua2";
            this.btnChinhSua2.Size = new System.Drawing.Size(91, 23);
            this.btnChinhSua2.TabIndex = 4;
            this.btnChinhSua2.Text = "Chỉnh sửa";
            this.btnChinhSua2.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua1
            // 
            this.btnChinhSua1.Location = new System.Drawing.Point(481, 39);
            this.btnChinhSua1.Name = "btnChinhSua1";
            this.btnChinhSua1.Size = new System.Drawing.Size(91, 23);
            this.btnChinhSua1.TabIndex = 3;
            this.btnChinhSua1.Text = "Chỉnh sửa";
            this.btnChinhSua1.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Enabled = false;
            this.txtSoDienThoai.Location = new System.Drawing.Point(203, 160);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(219, 22);
            this.txtSoDienThoai.TabIndex = 12;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(60, 161);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(89, 16);
            this.lblSoDienThoai.TabIndex = 11;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(60, 39);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(110, 16);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ tên nhân viên:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(203, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(219, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(203, 39);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(60, 120);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 16);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(60, 79);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(58, 16);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(203, 78);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(219, 22);
            this.txtChucVu.TabIndex = 8;
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(254, 9);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(224, 25);
            this.lblQuanLyNhanVien.TabIndex = 15;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(484, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(229, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(99, 421);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(357, 421);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 459);
            this.Controls.Add(this.dgrvDanhSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "frmQuanLyNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChinhSua5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnChinhSua4;
        private System.Windows.Forms.Button btnChinhSua3;
        private System.Windows.Forms.Button btnChinhSua2;
        private System.Windows.Forms.Button btnChinhSua1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
    }
}