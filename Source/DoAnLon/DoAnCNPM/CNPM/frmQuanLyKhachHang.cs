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
    public partial class frmQuanLyKhachHang : Form
    {
        int flag;

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtMaKH.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            cbxGioiTinh.SelectedIndex = -1;
            cbxLoaiKhach.SelectedIndex = -1;
            cbxPhieuThue.SelectedIndex = -1;
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadListView();
            DisableTextBox();
        }

        private void LoadListView()
        {
            lvwKH.Items.Clear();
            DataSet ds = new DataSet();
            KhachHangDTO KH_DTO = new KhachHangDTO();
            ds = KhachHangBUS.HienThiDanhSachKhachHang(KH_DTO);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaKH"].ToString();
                item.SubItems.Add(dr["TenKH"].ToString());
                if (dr["GioiTinh"].ToString() == "True")
                    item.SubItems.Add("Nam");
                else item.SubItems.Add("Nữ");
                item.SubItems.Add(dr["GiayToTuyThan"].ToString());
                item.SubItems.Add(dr["DiaChi"].ToString());
                item.SubItems.Add(dr["SoDT"].ToString());
                item.SubItems.Add(dr["MaLK"].ToString());
                item.SubItems.Add(dr["MaPhieuThue"].ToString());
                lvwKH.Items.Add(item);
            }

            ds = KhachHangBUS.LayDuLieuMaPhieuThue("select MaPhieuThue from PhieuThuePhong");
            cbxPhieuThue.Items.Clear();
            foreach (DataRow dr2 in ds.Tables[0].Rows)
            {
                cbxPhieuThue.Items.Add(dr2["MaPhieuThue"].ToString());
            }
        }

        private void lvwKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableEdit();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            DisableTextBox();

            foreach (ListViewItem item in lvwKH.SelectedItems)
            {
                txtMaKH.Text = item.Text;
                txtTenKH.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam")
                    cbxGioiTinh.SelectedIndex = 0;
                else if (item.SubItems[2].Text == "Nữ")
                    cbxGioiTinh.SelectedIndex = 1;
                txtCMND.Text = item.SubItems[3].Text;
                txtDiaChi.Text = item.SubItems[4].Text;
                txtSDT.Text = item.SubItems[5].Text;
                if (item.SubItems[6].Text == "1")
                    cbxLoaiKhach.SelectedIndex = 0;
                else cbxLoaiKhach.SelectedIndex = 1;
                cbxPhieuThue.Text = item.SubItems[7].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            ClearAll();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            DisableEdit();
            EnableTextBox();
        }

        private void EnableEdit()
        {
            btnSuaCMND.Enabled = true;
            btnSuaDiaChi.Enabled = true;
            btnSuaGioiTinh.Enabled = true;
            btnSuaLoaiKhach.Enabled = true;
            btnSuaPhieuThue.Enabled = true;
            btnSuaSDT.Enabled = true;
            btnSuaTenKH.Enabled = true;
        }

        private void DisableEdit()
        {
            btnSuaCMND.Enabled = false;
            btnSuaDiaChi.Enabled = false;
            btnSuaGioiTinh.Enabled = false;
            btnSuaLoaiKhach.Enabled = false;
            btnSuaPhieuThue.Enabled = false;
            btnSuaSDT.Enabled = false;
            btnSuaTenKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            DisableEdit();
        }

        private void DisableTextBox()
        {
            txtCMND.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtMaKH.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            cbxGioiTinh.Enabled = false;
            cbxLoaiKhach.Enabled = false;
            cbxPhieuThue.Enabled = false;
        }

        private void EnableTextBox()
        {
            txtCMND.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtMaKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            cbxGioiTinh.Enabled = true;
            cbxLoaiKhach.Enabled = true;
            cbxPhieuThue.Enabled = true;
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
            // Lấy thông tin khách hàng
            KhachHangDTO KH_DTO = new KhachHangDTO();
            KH_DTO.IMaKH = int.Parse(txtMaKH.Text);
            if (cbxGioiTinh.SelectedIndex == 0)
                KH_DTO.BGioiTinh = true;
            else KH_DTO.BGioiTinh = false;
            KH_DTO.StrTenKH = txtTenKH.Text;
            KH_DTO.StrSoDienThoai = txtSDT.Text;
            KH_DTO.StrDiaChi = txtDiaChi.Text;
            if (txtCMND.Text != "")
                KH_DTO.LGiayToTuyThan = long.Parse(txtCMND.Text);
            if (cbxPhieuThue.SelectedItem.ToString() != "-1")
                KH_DTO.IMaPhieuThue = int.Parse(cbxPhieuThue.SelectedItem.ToString());
            KH_DTO.IMaLK = cbxLoaiKhach.SelectedIndex + 1;

            if (flag == 0) // Nút thêm được click
            {
                try
                {
                    if (KH_DTO.IMaKH.ToString() != "")
                    {
                        if (KhachHangBUS.ThemKhachHang(KH_DTO))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadListView();
                            ClearAll();
                            btnLuu.Enabled = false;
                            btnThem.Enabled = true;
                            btnXoa.Enabled = false;
                            DisableEdit();
                            DisableTextBox();
                        }
                        else MessageBox.Show("Mã khách hàng đã tồn tại");
                    }
                    else MessageBox.Show("Chưa nhập mã khách hàng");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chương trình!");
                }
            }
            else
                if (flag == 1) // Nút xóa được click
                {
                    try
                    {
                        if (KhachHangBUS.XoaKhachHang(KH_DTO))
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadListView();
                            ClearAll();
                            btnLuu.Enabled = false;
                            btnXoa.Enabled = false;
                            btnThem.Enabled = true;
                            DisableEdit();
                            DisableTextBox();
                        }
                        else MessageBox.Show("Mã khách hàng không tồn tại");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chương trình!");
                    }
                }
                else // Nút sửa được click
                {
                    try
                    {
                        if (KhachHangBUS.SuaKhachHang(KH_DTO))
                        {
                            MessageBox.Show("Sửa thành công");
                            LoadListView();
                            ClearAll();
                            btnLuu.Enabled = false;
                            btnXoa.Enabled = false;
                            btnThem.Enabled = true;
                            DisableEdit();
                            DisableTextBox();
                        }
                        else MessageBox.Show("Mã khách hàng không tồn tại");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chương trình!");
                    }
                }
        }

        private void btnSuaTenKH_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaTenKH.Enabled = false;
            txtTenKH.ReadOnly = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaGioiTinh_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaGioiTinh.Enabled = false;
            cbxGioiTinh.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaCMND_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaCMND.Enabled = false;
            txtCMND.ReadOnly = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaDiaChi_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaDiaChi.Enabled = false;
            txtDiaChi.ReadOnly = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaSDT_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaSDT.Enabled = false;
            txtSDT.ReadOnly = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaLoaiKhach_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaLoaiKhach.Enabled = false;
            cbxLoaiKhach.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSuaPhieuThue_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSuaPhieuThue.Enabled = false;
            cbxPhieuThue.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
    }
}