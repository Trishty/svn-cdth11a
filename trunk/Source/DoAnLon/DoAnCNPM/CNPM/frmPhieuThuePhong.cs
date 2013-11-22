using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace CNPM
{
    public partial class frmPhieuThuePhong : Form
    {
        public frmPhieuThuePhong()
        {
            InitializeComponent();
        }

        #region Biến dữ liệu
        int iSTT = 0;
        int rownum = 0;
        int iFlag = 0;
        PhieuThueDTO ptDTO = new PhieuThueDTO();
        #endregion

        #region PageLoad
        private void frmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            //Nạp danh sách phòng
            DataSet ds = new DataSet();
            ds = PhieuThueBUS.LayDanhSachPhong(ptDTO);
            cboPhong.DataSource = ds.Tables[0];
            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;
            DisableControl();
            btnLuu.Enabled = false;
        }
        #endregion

        #region Tắt control
        private void DisableControl()
        {
            txtMa.Enabled = false;
            cboPhong.Enabled = false;
            dtThue.Enabled = false;
            dtTra.Enabled = false;
            dataGridView1.Enabled = false;
        }
        #endregion

        #region Mở control
        private void EnableControl()
        {
            txtMa.Enabled = false;
            cboPhong.Enabled = true;
            dtThue.Enabled = false;
            dtTra.Enabled = true;
            dataGridView1.Enabled = true;
        }
        #endregion

        #region Tạo DataGridView
        private void TaoDataGridView()
        {
            dataGridView1.Enabled = true;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn MaKH = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TenKH = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn LoaiKH = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn GioiTinh = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DienThoai = new DataGridViewTextBoxColumn();

            DataSet dsLoaiKhach = new DataSet();
            dsLoaiKhach = PhieuThueBUS.LayDanhLoaiKhach(ptDTO);
            LoaiKH.DataSource = dsLoaiKhach.Tables[0];
            LoaiKH.DisplayMember = "TenLK";
            LoaiKH.ValueMember = "MaLK";

            GioiTinh.Items.Add("Nam");
            GioiTinh.Items.Add("Nữ");

            MaKH.HeaderText = "Mã KH";
            TenKH.HeaderText = "Khách Hàng";
            LoaiKH.HeaderText = "Loại Khách";
            CMND.HeaderText = "Giấy Tờ Tuỳ Thân";
            GioiTinh.HeaderText = "Giới Tính";
            DiaChi.HeaderText = "Địa Chỉ";
            DienThoai.HeaderText = "Điện Thoại";

            dataGridView1.Columns.Add(MaKH);
            dataGridView1.Columns.Add(TenKH);
            dataGridView1.Columns.Add(LoaiKH);
            dataGridView1.Columns.Add(CMND);
            dataGridView1.Columns.Add(GioiTinh);
            dataGridView1.Columns.Add(DiaChi);
            dataGridView1.Columns.Add(DienThoai);

            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.Columns[0].ReadOnly = true;
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (iFlag == 1)
            {
                //Thêm phiếu thuê
                
                //Thông tin phiếu thuê
                ptDTO.MaPT = txtMa.Text;
                ptDTO.Phong = cboPhong.Text;
                ptDTO.NgayThue = dtThue.Text;
                ptDTO.NgayTra = dtTra.Text;

                if (PhieuThueBUS.ThemPT(ptDTO) == true)
                {
                    //Thông tin khách hàng
                    int iDong = dataGridView1.Rows.Count;
                    int iLoi = 0;
                    for (int i = 0; i < iDong - 1; i++)
                    {
                        ptDTO.MaKH = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ptDTO.KhachHang = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ptDTO.LoaiKhach = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ptDTO.CMND = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Nam")
                            ptDTO.GioiTinh = "True";
                        else
                            ptDTO.GioiTinh = "False";
                        ptDTO.DiaChi = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        ptDTO.DienThoai = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        try
                        {
                            iLoi = 0;
                            PhieuThueBUS.ThemKH(ptDTO);
                        }
                        catch
                        {
                            iLoi = 1;
                        }
                        if (iLoi != 1 && i == iDong - 2)
                        {
                            MessageBox.Show("Lập phiếu thuê thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Lập phiếu thuê thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lập phiếu thuê thất bại!");
                }
                
            }
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            iFlag = 1;
            ptDTO.MaPT = PhieuThueBUS.LayMaTuPhieuDong(ptDTO);
            ptDTO.MaKH = PhieuThueBUS.LayMaTuKHDong(ptDTO);
            if (ptDTO.MaPT != "")
            {
                int iPT = Convert.ToInt32(ptDTO.MaPT);
                iPT += 1;
                txtMa.Text = iPT.ToString();
            }
            cboPhong.SelectedIndex = 0;
            iSTT = Convert.ToInt32(ptDTO.MaKH);
            rownum = 0;
            TaoDataGridView();
            EnableControl();
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
        }
        #endregion

        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tạo STT tự động
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            iSTT += 1;
            dataGridView1.Rows[rownum].Cells[0].Value = iSTT;
            rownum += 1;
        }
        #endregion
    }
}