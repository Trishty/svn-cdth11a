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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        #region Biến dữ liệu
        int iSTT = 0;
        int rownum = 0;
        int iFlag = 0;
        HoaDonDTO hdDTO = new HoaDonDTO();
        #endregion

        #region PageLoad
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataSet dsTenKH = new DataSet();
            DataSet dsTenNV = new DataSet();
            dsTenKH = HoaDonBUS.LayDanhSachKH(hdDTO);
            dsTenNV = HoaDonBUS.LayDanhSachNV(hdDTO);
            //Nạp danh sách Khách hàng
            cboTenKH.DataSource = dsTenKH.Tables[0];
            cboTenKH.DisplayMember = "TenKH";
            cboTenKH.ValueMember = "MaKH";
            cboTenKH.SelectedIndex = -1;
            //Nạp danh sách Nhân viên
            cboTenNV.DataSource = dsTenNV.Tables[0];
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.ValueMember = "TenDN";
            cboTenNV.SelectedIndex = -1;
            DisableControl();
            btnTinh.Enabled = false;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Tắt control
        private void DisableControl()
        {
            txtMaHD.Enabled = false;
            cboTenKH.Enabled = false;
            cboTenNV.Enabled = false;
            txtDC.Enabled = false;
            dtLap.Enabled = false;
            dataGridView1.Enabled = false;
            txtTriGia.Enabled = false;
        }
        #endregion

        #region Mở control
        private void EnableControl()
        {
            cboTenKH.Enabled = true;
            cboTenNV.Enabled = true;
            dataGridView1.Enabled = true;
        }
        #endregion

        #region Tạo DataGridView
        private void CreateDataGridView()
        {
            dataGridView1.Enabled = true;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn STT = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn Phong = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn SLKhach = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn SoNgayThue = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DonGia = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn PhuThu = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn HeSo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ThanhTien = new DataGridViewTextBoxColumn();

            DataSet dsPhong = new DataSet();
            dsPhong = HoaDonBUS.LayDanhSachPhong(hdDTO);
            Phong.DataSource = dsPhong.Tables[0];
            Phong.DisplayMember = "MaPhong";
            Phong.ValueMember = "MaPhong";

            SLKhach.Items.Add("1");
            SLKhach.Items.Add("2");
            SLKhach.Items.Add("3");

            STT.HeaderText = "STT";
            Phong.HeaderText = "Phòng";
            SLKhach.HeaderText = "SL Khách";
            SoNgayThue.HeaderText = "Số Ngày Thuê";
            DonGia.HeaderText = "Đơn Giá";
            PhuThu.HeaderText = "Phụ Thu";
            HeSo.HeaderText = "Hệ Số";
            ThanhTien.HeaderText = "Thành Tiền";

            dataGridView1.Columns.Add(STT);
            dataGridView1.Columns.Add(Phong);
            dataGridView1.Columns.Add(SLKhach);
            dataGridView1.Columns.Add(SoNgayThue);
            dataGridView1.Columns.Add(DonGia);
            dataGridView1.Columns.Add(PhuThu);
            dataGridView1.Columns.Add(HeSo);
            dataGridView1.Columns.Add(ThanhTien);

            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (iFlag == 1)
            {
                //Thêm hoá đơn

                //Thông tin hoá đơn
                hdDTO.MaHD = txtMaHD.Text;
                hdDTO.MaKH = cboTenKH.SelectedValue.ToString();
                hdDTO.TenDN = cboTenNV.SelectedValue.ToString();
                hdDTO.DCKH = txtDC.Text;
                hdDTO.NgayLap = dtLap.Text;
                hdDTO.TriGia = txtTriGia.Text;

                if (HoaDonBUS.ThemHD(hdDTO) == true)
                {
                    //Thông tin chi tiết hoá đơn
                    int iDong = dataGridView1.Rows.Count;
                    int iLoi = 0;
                    for (int i = 0; i < iDong - 1; i++)
                    {
                        hdDTO.Phong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        hdDTO.SLKhach = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        hdDTO.SoNgayThue = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        hdDTO.DonGia = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        try
                        {
                            iLoi = 0;
                            HoaDonBUS.ThemCT(hdDTO);
                        }
                        catch
                        {
                            iLoi = 1;
                        }
                        if (iLoi != 1 && i == iDong - 2)
                        {
                            MessageBox.Show("Lập hoá đơn thành công!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lập hoá đơn thất bại!");
                }
            }
            btnHuy.Enabled = true;
            btnTinh.Enabled = false;
            btnLuu.Enabled = false;
        }
        #endregion

        #region Huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            iFlag = 1;
            hdDTO.MaHD = HoaDonBUS.LayMaHDTuDong(hdDTO);
            if (hdDTO.MaHD != "")
            {
                int iHD = Convert.ToInt32(hdDTO.MaHD);
                iHD += 1;
                txtMaHD.Text = iHD.ToString();
            }
            cboTenKH.SelectedIndex = 0;
            cboTenNV.SelectedIndex = 0;
            txtTriGia.Text = "";       
            iSTT = 0;
            rownum = 0;
            CreateDataGridView();
            EnableControl();
            btnHuy.Enabled = false;
            btnTinh.Enabled = true;
        }
        #endregion

        #region Lấy địa chỉ
        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKH.SelectedIndex != -1)
            {
                hdDTO.MaKH = cboTenKH.SelectedValue.ToString();
                txtDC.Text = HoaDonBUS.LayDiaChiKH(hdDTO);
            }
        }
        #endregion

        #region Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Cột thay đổi
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = dataGridView1.Rows.Count;
            if (iDong > 1)
            for (int i = 0; i < iDong; i++)
            {
                double dSLKH = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                if (dSLKH == 3)
                    dataGridView1.Rows[i].Cells[5].Value = "25";
                else if (dSLKH == 1)
                    dataGridView1.Rows[i].Cells[6].Value = "1.5";
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "0";
                    dataGridView1.Rows[i].Cells[6].Value = "1";
                }
                hdDTO.Tam = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                if(hdDTO.Tam != null)
                    hdDTO.Tam = HoaDonBUS.LayLoaiPhong(hdDTO);
                dataGridView1.Rows[i].Cells[4].Value = HoaDonBUS.LayGiaVNPhong(hdDTO);
                if (dataGridView1.Rows[i].Cells[3].Value != null
                    && dataGridView1.Rows[i].Cells[4].Value != null)
                {
                    double dSoNgayThue = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    double dDonGia = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    double dPhuThu = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    double dHeSo = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    double dThanhTien = (dSoNgayThue * dDonGia + dDonGia * dPhuThu / 100) * dHeSo;
                    dataGridView1.Rows[i].Cells[7].Value = dThanhTien.ToString();
                }
                else
                    dataGridView1.Rows[i].Cells[7].Value = "";
            }
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

        #region Tính Tiền
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double dTriGia = 0;
            int iDongTinh = dataGridView1.Rows.Count;
            for (int j = 0; j < iDongTinh - 1; j++)
            {
                double dTongTien = Convert.ToDouble(dataGridView1.Rows[j].Cells[7].Value);
                dTriGia += dTongTien;
                txtTriGia.Text = dTriGia.ToString();
            }
            btnLuu.Enabled = true;
            btnTinh.Enabled = false;
        }
        #endregion
    }
}