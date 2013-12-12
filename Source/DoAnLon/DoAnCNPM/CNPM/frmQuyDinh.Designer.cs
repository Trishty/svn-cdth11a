namespace CNPM
{
    partial class frmQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyDinh));
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.btnDanhDauLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(50, 26);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(58, 13);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã phòng:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(183, 20);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(262, 20);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(183, 60);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(262, 20);
            this.txtTen.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(50, 63);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(58, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Mã phòng:";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(183, 100);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(262, 20);
            this.txtGiaTri.TabIndex = 0;
            this.txtGiaTri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_KeyPress);
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Location = new System.Drawing.Point(50, 102);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(58, 13);
            this.lblGiaTri.TabIndex = 4;
            this.lblGiaTri.Text = "Mã phòng:";
            // 
            // btnDanhDauLuu
            // 
            this.btnDanhDauLuu.Location = new System.Drawing.Point(136, 142);
            this.btnDanhDauLuu.Name = "btnDanhDauLuu";
            this.btnDanhDauLuu.Size = new System.Drawing.Size(108, 23);
            this.btnDanhDauLuu.TabIndex = 6;
            this.btnDanhDauLuu.Text = "Đánh Dấu Lưu";
            this.btnDanhDauLuu.UseVisualStyleBackColor = true;
            this.btnDanhDauLuu.Click += new System.EventHandler(this.btnDanhDauLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(286, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Hủy Bỏ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 190);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDanhDauLuu);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuyDinh";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Button btnDanhDauLuu;
        private System.Windows.Forms.Button btnThoat;

    }
}