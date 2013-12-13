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

        int flag;

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void LoadListView()
        {
            lvwNhanVien.Items.Clear();
            DataSet ds = new DataSet();
            NhanVienDTO NV_DTO = new NhanVienDTO();
            ds = NhanVienBUS.HienThiDanhSachSinhVien(NV_DTO);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["TenDN"].ToString();
                item.SubItems.Add(dr["MatKhau"].ToString());
                item.SubItems.Add(dr["TenNV"].ToString());
                item.SubItems.Add(dr["DiaChi"].ToString());
                item.SubItems.Add(dr["DienThoai"].ToString());
                item.SubItems.Add(dr["CMND"].ToString());
                lvwNhanVien.Items.Add(item);
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Enable();
            Empty();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnChinhSua1.Enabled = false;
            btnChinhSua2.Enabled = false;
            btnChinhSua3.Enabled = false;
            btnChinhSua4.Enabled = false;
            btnChinhSua5.Enabled = false;
            btnChinhSua6.Enabled = false;
            btnChinhSua7.Enabled = false;
        }

        private void Enable()
        {
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtReMatKhau.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtHoTen.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void Disable()
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            txtReMatKhau.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtHoTen.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void Empty()
        {
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtReMatKhau.Text = "";
            txtSoDienThoai.Text = "";
            txtTenDangNhap.Text = "";
        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disable();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

            btnChinhSua1.Enabled = true;
            btnChinhSua2.Enabled = true;
            btnChinhSua3.Enabled = true;
            btnChinhSua4.Enabled = true;
            btnChinhSua5.Enabled = true;
            btnChinhSua6.Enabled = true;
            btnChinhSua7.Enabled = true;

            foreach (ListViewItem item in lvwNhanVien.SelectedItems)
            {
                txtTenDangNhap.Text = item.Text;
                txtMatKhau.Text = item.SubItems[1].Text;
                txtReMatKhau.Text = item.SubItems[1].Text;
                txtHoTen.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoDienThoai.Text = item.SubItems[4].Text;
                txtCMND.Text = item.SubItems[5].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO QLNV_DTO = new NhanVienDTO();
            QLNV_DTO.StrTenDangNhap = txtTenDangNhap.Text;
            QLNV_DTO.StrMatKhau = txtMatKhau.Text;
            QLNV_DTO.StrHoTen = txtHoTen.Text;
            QLNV_DTO.StrDiaChi = txtDiaChi.Text;
            QLNV_DTO.StrDienThoai = txtSoDienThoai.Text;
            QLNV_DTO.StrCMND = txtCMND.Text;

            if (flag == 0) // Thêm nhân viên
            {
                try
                {
                    if (QLNV_DTO.StrTenDangNhap.ToString() != "" && QLNV_DTO.StrMatKhau.ToString() == txtReMatKhau.Text)
                    {
                        if (NhanVienBUS.ThemNhanVien(QLNV_DTO))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadListView();
                            Empty();
                            Disable();
                        }
                        else MessageBox.Show("Tên tài khoản đã tồn tại");
                    }
                    else MessageBox.Show("Mật khẩu không trùng khớp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chương trình!");
                }
            }
            else
                if (flag == 1) // Xóa nhân viên
                {
                    try
                    {
                        if (NhanVienBUS.XoaNhanVien(QLNV_DTO))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadListView();
                            Empty();
                            Disable();
                        }
                        else MessageBox.Show("Tên tài khoản không tồn tại");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chương trình!");
                    }
                }
                else // Sửa nhân viên
                {
                    try
                    {
                        if (NhanVienBUS.SuaNhanVien(QLNV_DTO))
                        {
                            MessageBox.Show("Sửa thành công");
                            LoadListView();
                            Empty();
                            Disable();

                            btnChinhSua1.Enabled = false;
                            btnChinhSua2.Enabled = false;
                            btnChinhSua3.Enabled = false;
                            btnChinhSua4.Enabled = false;
                            btnChinhSua5.Enabled = false;
                            btnChinhSua6.Enabled = false;
                            btnChinhSua7.Enabled = false;
                        }
                        else MessageBox.Show("Tên tài khoản không tồn tại");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chương trình!");
                    }
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;

        }

        private void btnChinhSua5_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua5.Enabled = false;
            txtTenDangNhap.Enabled = true;
        }

        private void btnChinhSua6_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua6.Enabled = false;
            btnChinhSua7.Enabled = false;
            txtMatKhau.Enabled = true;
            txtReMatKhau.Enabled = true;
        }

        private void btnChinhSua7_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua6.Enabled = false;
            btnChinhSua7.Enabled = false;
            txtMatKhau.Enabled = true;
            txtReMatKhau.Enabled = true;
        }

        private void btnChinhSua1_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua1.Enabled = false;
            txtHoTen.Enabled = true;
        }

        private void btnChinhSua2_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua2.Enabled = false;
            txtDiaChi.Enabled = true;
        }

        private void btnChinhSua3_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua3.Enabled = false;
            txtSoDienThoai.Enabled = true;
        }

        private void btnChinhSua4_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua4.Enabled = false;
            txtCMND.Enabled = true;
        }
    }
}