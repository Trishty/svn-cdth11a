namespace CNPM
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPT = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnQD = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.sttbar = new System.Windows.Forms.StatusStrip();
            this.stt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sttbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDM
            // 
            this.btnDM.Location = new System.Drawing.Point(42, 89);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(255, 42);
            this.btnDM.TabIndex = 1;
            this.btnDM.Text = "Lập danh mục phòng";
            this.btnDM.UseVisualStyleBackColor = true;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Sạn";
            // 
            // btnPT
            // 
            this.btnPT.Location = new System.Drawing.Point(42, 151);
            this.btnPT.Name = "btnPT";
            this.btnPT.Size = new System.Drawing.Size(255, 42);
            this.btnPT.TabIndex = 2;
            this.btnPT.Text = "Lập phiếu thuê phòng";
            this.btnPT.UseVisualStyleBackColor = true;
            this.btnPT.Click += new System.EventHandler(this.btnPT_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(42, 211);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(255, 42);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "Tra cứu phòng";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(361, 89);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(255, 42);
            this.btnHD.TabIndex = 6;
            this.btnHD.Text = "Lập hoá đơn thanh toán";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(361, 151);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(255, 42);
            this.btnBC.TabIndex = 7;
            this.btnBC.Text = "Lập báo cáo tháng";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnQD
            // 
            this.btnQD.Location = new System.Drawing.Point(361, 211);
            this.btnQD.Name = "btnQD";
            this.btnQD.Size = new System.Drawing.Size(255, 42);
            this.btnQD.TabIndex = 8;
            this.btnQD.Text = "Thay đổi qui định";
            this.btnQD.UseVisualStyleBackColor = true;
            this.btnQD.Click += new System.EventHandler(this.btnQD_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(361, 270);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(255, 42);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(361, 332);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(255, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNV
            // 
            this.btnNV.Location = new System.Drawing.Point(42, 270);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(255, 42);
            this.btnNV.TabIndex = 4;
            this.btnNV.Text = "Quản lý nhân viên";
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnKH
            // 
            this.btnKH.Location = new System.Drawing.Point(42, 332);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(255, 42);
            this.btnKH.TabIndex = 5;
            this.btnKH.Text = "Quản lý khách hàng";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // sttbar
            // 
            this.sttbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stt1});
            this.sttbar.Location = new System.Drawing.Point(0, 384);
            this.sttbar.Name = "sttbar";
            this.sttbar.Size = new System.Drawing.Size(665, 22);
            this.sttbar.TabIndex = 11;
            this.sttbar.Text = "statusStrip1";
            // 
            // stt1
            // 
            this.stt1.Name = "stt1";
            this.stt1.Size = new System.Drawing.Size(123, 17);
            this.stt1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 406);
            this.Controls.Add(this.sttbar);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQD);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnPT);
            this.Controls.Add(this.btnDM);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sttbar.ResumeLayout(false);
            this.sttbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPT;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnQD;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.StatusStrip sttbar;
        private System.Windows.Forms.ToolStripStatusLabel stt1;
        private System.Windows.Forms.Timer timer1;
    }
}