using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace CNPM
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgrvDanhSach.Columns.Clear();
            DataSet ds = new DataSet();
            NhanVienDTO NV_DTO = new NhanVienDTO();
            ds = NhanVienBUS.HienThiDanhSachSinhVien(NV_DTO);

            dgrvDanhSach.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void Empty()
        {
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtReMatKhau.Text = "";
            txtSoDienThoai.Text = "";
            txtTenDangNhap.Text = "";
        }
    }
}