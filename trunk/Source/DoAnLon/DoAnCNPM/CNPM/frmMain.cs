using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stt1.Text = DateTime.Now.ToString();
        }

        #region Lập danh mục
        private void btnDM_Click(object sender, EventArgs e)
        {
            frmDanhMucPhong DM = new frmDanhMucPhong();
            DM.ShowDialog();
        }
        #endregion

        #region Lập phiếu đặt
        private void btnPT_Click(object sender, EventArgs e)
        {
            frmPhieuThuePhong PT = new frmPhieuThuePhong();
            PT.ShowDialog();
        }
        #endregion

        #region Lập Thống Kê
        private void btnTK_Click(object sender, EventArgs e)
        {
            frmTraCuuPhong TK = new frmTraCuuPhong();
            TK.ShowDialog();
        }
        #endregion

        #region Quản lý nhân viên
        private void btnNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien NV = new frmQuanLyNhanVien();
            NV.ShowDialog();
        }
        #endregion

        #region Quản lý khách hàng
        private void btnKH_Click(object sender, EventArgs e)
        {
            //frmQuanLyKhachHang KH = new frmQuanLyKhachHang();
            //KH.ShowDialog();
        }
        #endregion

        #region Lập hoá đơn
        private void btnHD_Click(object sender, EventArgs e)
        {
            frmHoaDon HD = new frmHoaDon();
            HD.ShowDialog();
        }
        #endregion

        #region Lập báo cáo
        private void btnBC_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoDoanhThu BC = new frmLapBaoCaoDoanhThu();
            BC.ShowDialog();
        }
        #endregion

        #region Thay đổi quy định
        private void btnQD_Click(object sender, EventArgs e)
        {
            frmThayDoiCacQuyDinh QD = new frmThayDoiCacQuyDinh();
            QD.ShowDialog();
        }
        #endregion

        #region Logout
        private void btnAbout_Click(object sender, EventArgs e)
        {
            DialogResult Logout = new DialogResult();
            string strLogout = "Bạn muốn đăng xuất?";
            Logout = MessageBox.Show(strLogout, "Quản Lý Khách Sạn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Logout == DialogResult.Yes)
            {
                frmDangNhap DN = new frmDangNhap();
                DN.Show();
                this.Hide();
                this.Dispose();
            }
        }
        #endregion

        #region Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat = new DialogResult(); ;
            Thoat = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}