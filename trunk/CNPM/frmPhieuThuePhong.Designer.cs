namespace CNPM
{
    partial class frmPhieuThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.dtThue = new System.Windows.Forms.DateTimePicker();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboMaPT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lập Phiếu Thuê Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Phiếu Thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày thuê phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.KH,
            this.LoaiKH,
            this.ID,
            this.GioiTinh,
            this.DC,
            this.SoDT});
            this.dataGridView1.Location = new System.Drawing.Point(23, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 65;
            // 
            // KH
            // 
            this.KH.HeaderText = "Khách Hàng";
            this.KH.Name = "KH";
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loại Khách";
            this.LoaiKH.Items.AddRange(new object[] {
            "Nội Địa",
            "Nước Ngoài"});
            this.LoaiKH.Name = "LoaiKH";
            // 
            // ID
            // 
            this.ID.HeaderText = "Giấy Tờ Tùy Thân";
            this.ID.Name = "ID";
            this.ID.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GioiTinh.Width = 75;
            // 
            // DC
            // 
            this.DC.HeaderText = "Địa Chỉ";
            this.DC.Name = "DC";
            // 
            // SoDT
            // 
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.Name = "SoDT";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(404, 372);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(136, 372);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Lập mới";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(538, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày trả phòng";
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(354, 153);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(143, 20);
            this.dtTra.TabIndex = 3;
            // 
            // dtThue
            // 
            this.dtThue.Enabled = false;
            this.dtThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThue.Location = new System.Drawing.Point(354, 126);
            this.dtThue.Name = "dtThue";
            this.dtThue.Size = new System.Drawing.Size(143, 20);
            this.dtThue.TabIndex = 14;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(353, 100);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(144, 21);
            this.cboPhong.TabIndex = 15;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 372);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMaPT
            // 
            this.cboMaPT.FormattingEnabled = true;
            this.cboMaPT.Location = new System.Drawing.Point(354, 74);
            this.cboMaPT.Name = "cboMaPT";
            this.cboMaPT.Size = new System.Drawing.Size(144, 21);
            this.cboMaPT.TabIndex = 17;
            this.cboMaPT.SelectedIndexChanged += new System.EventHandler(this.cboMaPT_SelectedIndexChanged);
            // 
            // frmPhieuThuePhong
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(749, 416);
            this.Controls.Add(this.cboMaPT);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.dtThue);
            this.Controls.Add(this.dtTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.frmPhieuThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.DateTimePicker dtThue;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboMaPT;
    }
}